using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    public partial class MainFormProgLangControl : UserControl
    {
        private readonly MyDBContext db;

        private Logger Log;
        public UserModel User { get; set; }
        public ProgrammingLanguageModel Python { get; set; }
        public ProgrammingLanguageModel CSharp { get; set; }
        public ProgrammingLanguageModel JavaScript { get; set; }
        public ProgrammingLanguageModel CPlus { get; set; }
        public ProgrammingLanguageModel Java { get; set; }
        public MainFormProgLangControl(UserModel user)
        {
            InitializeComponent();

            Log = LogManager.GetCurrentClassLogger();

            db = new MyDBContext();

            User = user;

            Python = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "Python",
                Purpose = new List<string>()
                {
                    "Веб-разработка",
                    "ML/AI"
                },
                DifficultyLanguage = Difficulty.Easy,
                DescriptionLanguage = Description.Nocturnal,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            CSharp = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "C#",
                Purpose = new List<string>()
                {
                    "Windows-приложения",
                    "Игры",
                    "Базы данных"
                },
                DifficultyLanguage = Difficulty.Medium,
                DescriptionLanguage = Description.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            JavaScript = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "JavaScript",
                Purpose = new List<string>()
                {
                    "Веб-разработка",
                    "Мобильные и десктопные приложения"
                },
                DifficultyLanguage = Difficulty.Medium,
                DescriptionLanguage = Description.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            CPlus = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "C++",
                Purpose = new List<string>()
                {
                    "Системное ПО",
                    "Игры",
                },
                DifficultyLanguage = Difficulty.Medium,
                DescriptionLanguage = Description.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            Java = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "Java",
                Purpose = new List<string>()
                {
                    "Веб-разработка",
                    "Мобильные и десктопные приложения",
                    "Серверы"
                },
                DifficultyLanguage = Difficulty.Medium,
                DescriptionLanguage = Description.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };

            db.Add(Python);
            db.Add(CSharp);
            db.Add(JavaScript);
            db.Add(CPlus);
            db.Add(Java);
            db.SaveChanges();


            Log.Info("Переход к форме языков программирования");
        }



        private void listBoxFilteredLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbDescriptionLanguage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
