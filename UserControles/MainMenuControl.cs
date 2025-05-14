using Microsoft.EntityFrameworkCore;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations
{
    /// <summary>
    /// Форма главного меню после заполнения анкеты
    /// </summary>
    public partial class MainMenuControl : UserControl
    {
        /// <summary>
        /// Пользватель
        /// </summary>
        public UserModel User { get; set; }
        private AdditionalMethodsClass additionalMethods { get; set; }

        private readonly MyDBContext db;

        private Logger Log;

        public MainMenuControl(UserModel user)
        {
            InitializeComponent();

            Log = LogManager.GetCurrentClassLogger();
            User = user;
            additionalMethods = new AdditionalMethodsClass();
            db = new MyDBContext();

            SelectedLanguage();

            Log.Info("Переход к форме главного меню");
        }

        private async void SelectedLanguage()
        {
            var dbUser = await db.Users
            .Include(u => u.FormModel)
            .Include(u => u.UsersProgrammingLanguage)
            .FirstOrDefaultAsync(u => u.Id == User.Id);

            var allForms = await db.FormModels.ToListAsync();
            var similarForms = new List<FormModel>();

            var allLanguages = await db.ProgrammingLanguages
                                .Include(l => l.Purposes)
                                .ToListAsync();

            var languages = new Dictionary<string, int>();
            foreach (var language in allLanguages)
            {
                languages.Add(language.Name, 0);
            }

            foreach (var form in allForms)
            {
                if (form.Id == dbUser.FormModel.Id)
                    continue;

                var sameAnswers = 0;
                if (dbUser.FormModel.PurposeForm == form.PurposeForm)
                {
                    sameAnswers += 1;
                }
                if (dbUser.FormModel.ProgrammingSkillUser == form.ProgrammingSkillUser)
                {
                    sameAnswers += 1;
                }
                if (dbUser.FormModel.Priority == form.Priority)
                {
                    sameAnswers += 1;
                }
                if (dbUser.FormModel.TimeEducationInWeek == form.TimeEducationInWeek)
                {
                    sameAnswers += 1;
                }

                if (sameAnswers >= 2)
                {
                    similarForms.Add(form);
                }
            }

            if (similarForms.Count == 0)
            {
                foreach (var lang in allLanguages)
                {
                    if (lang.Purposes.Contains(dbUser.FormModel.PurposeForm))
                    {
                        languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 1;
                    }

                    if (dbUser.FormModel.ProgrammingSkillUser == ProgrammingSkill.Nocturnal)
                    {
                        if (lang.DifficultyLanguage == Difficulty.Easy)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 1;
                        }
                    }
                    else if (dbUser.FormModel.ProgrammingSkillUser == ProgrammingSkill.Intermediate)
                    {
                        if (lang.DifficultyLanguage == Difficulty.Easy)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 1;
                        }
                        if (lang.DifficultyLanguage == Difficulty.Medium)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 2;
                        }
                    }
                    else if (dbUser.FormModel.ProgrammingSkillUser == ProgrammingSkill.Advanced)
                    {
                        if (lang.DifficultyLanguage == Difficulty.Easy)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 1;
                        }
                        if (lang.DifficultyLanguage == Difficulty.Medium)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 2;
                        }
                        if (lang.DifficultyLanguage == Difficulty.Difficult)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 3;
                        }
                    }

                    if (dbUser.FormModel.TimeEducationInWeek == TimeToEducation.LessThanThreeHours)
                    {
                        if (lang.DifficultyLanguage == Difficulty.Easy)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 1;
                        }
                    }
                    else if (dbUser.FormModel.TimeEducationInWeek == TimeToEducation.ThreeToFiveHours)
                    {
                        if (lang.DifficultyLanguage == Difficulty.Easy)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 1;
                        }
                        if (lang.DifficultyLanguage == Difficulty.Medium)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 2;
                        }
                    }
                    else if (dbUser.FormModel.TimeEducationInWeek == TimeToEducation.SixToTenPlusHours)
                    {
                        if (lang.DifficultyLanguage == Difficulty.Easy)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 1;
                        }
                        if (lang.DifficultyLanguage == Difficulty.Medium)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 2;
                        }
                        if (lang.DifficultyLanguage == Difficulty.Difficult)
                        {
                            languages[lang.Name] = languages.GetValueOrDefault(lang.Name) + 3;
                        }
                    }
                }

                if (dbUser.UsersProgrammingLanguage == null)
                    dbUser.UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>();

                var top3Languages = languages
                    .OrderByDescending(pair => pair.Value)
                    .Take(3)
                    .Select(pair => pair.Key)
                    .ToList();

                var languageDb = await db.ProgrammingLanguages
                        .Where(pl => top3Languages.Contains(pl.Name))
                        .ToListAsync();


                foreach (var lang in languageDb)
                {
                    bool exists = await db.UserProgrammingLanguages
                        .AnyAsync(upl => upl.UserId == dbUser.Id && upl.ProgrammingLanguageId == lang.Id);

                    if (!exists)
                    {
                        db.UserProgrammingLanguages.Add(new UserProgrammingLanguageModel
                        {
                            UserId = dbUser.Id,
                            ProgrammingLanguageId = lang.Id
                        });
                    }
                }


                await db.SaveChangesAsync();
            }
            else
            {
                var random = new Random();
                var randomForm = similarForms[random.Next(similarForms.Count)];

                // пользователь формы
                var usersWithThisForm = await db.Users
                                .Include(u => u.UsersProgrammingLanguage)
                                    .ThenInclude(upl => upl.ProgrammingLanguage)
                                .Where(u => u.FormModel.Id == randomForm.Id)
                                .ToListAsync();

                // языки пользователя
                var recommendedLanguages = usersWithThisForm
                    .SelectMany(u => u.UsersProgrammingLanguage)
                    .Select(upl => upl.ProgrammingLanguage)
                    .Distinct()
                    .ToList();

                // Удаляем старые языки
                var oldLanguages = await db.UserProgrammingLanguages
                    .Where(upl => upl.UserId == dbUser.Id)
                    .ToListAsync();

                db.UserProgrammingLanguages.RemoveRange(oldLanguages);
                await db.SaveChangesAsync();

                if (dbUser.UsersProgrammingLanguage == null)
                    dbUser.UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>();

                foreach (var lang in recommendedLanguages)
                {
                    bool exists = await db.UserProgrammingLanguages
                        .AnyAsync(upl => upl.UserId == dbUser.Id && upl.ProgrammingLanguageId == lang.Id);

                    if (!exists)
                    {
                        db.UserProgrammingLanguages.Add(new UserProgrammingLanguageModel
                        {
                            UserId = dbUser.Id,
                            ProgrammingLanguageId = lang.Id
                        });
                    }
                }

                await db.SaveChangesAsync();
            }

            var languageIds = dbUser.UsersProgrammingLanguage
                .Select(upl => upl.ProgrammingLanguageId)
                .ToList();

            var topLanguages = await db.ProgrammingLanguages
                .Where(pl => languageIds.Contains(pl.Id))
                .ToListAsync();

            if (topLanguages.Count > 0)
            {
                // Первый язык
                if (topLanguages.Count > 0)
                {
                    labelLang1.Text = topLanguages[0].Name;
                    pictureBoxLang1.Image = additionalMethods.ByteToImage(topLanguages[0].Image);
                }

                // Второй язык
                if (topLanguages.Count > 1)
                {
                    labelLang2.Text = topLanguages[1].Name;
                    pictureBoxLang2.Image = additionalMethods.ByteToImage(topLanguages[1].Image);
                }

                // Третий язык
                if (topLanguages.Count > 2)
                {
                    labelLang3.Text = topLanguages[2].Name;
                    pictureBoxLang3.Image = additionalMethods.ByteToImage(topLanguages[2].Image);
                }
            }
        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.Panel_Paint(panelMainMenu);
        }
    }
}
