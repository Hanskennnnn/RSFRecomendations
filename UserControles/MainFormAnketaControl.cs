using Microsoft.EntityFrameworkCore;
using NLog;
using RSFRecomendations.Models;

namespace RSFRecomendations.UserControles
{
    /// <summary>
    /// Форма анкеты
    /// </summary>
    public partial class MainFormAnketaControl : UserControl
    {
        private readonly MyDBContext db;

        /// <summary>
        /// Пользователь
        /// </summary>
        public UserModel User { get; set; }

        private Logger Log;

        private AdditionalMethodsClass additionalMethods;

        public FormModel model { get; set; }

        public MainFormAnketaControl(UserModel user)
        {
            InitializeComponent();

            db = new MyDBContext();
            model = new FormModel();
            additionalMethods = new AdditionalMethodsClass();
            Log = LogManager.GetCurrentClassLogger();
            User = user;

            Log.Info("Переход к форме анкеты");
        }

        private async void buttonAddForm_Click(object sender, EventArgs e)
        {
            var valuesQuestion1 = new List<RadioButton> { radioButtonQuestion1Answer1, radioButtonQuestion1Answer2, 
                radioButtonQuestion1Answer3,radioButtonQuestion1Answer4, 
                radioButtonQuestion1Answer5, radioButtonQuestion1Answer6 };
            var purposeForm = additionalMethods.GetPurposeForm(valuesQuestion1);

            var valuesQuestion2 = new List<RadioButton> { radioButtonQuestion2Answer1,
                radioButtonQuestion2Answer2, radioButtonQuestion2Answer3 };
            var progSkillForm = additionalMethods.GetProgSkill(valuesQuestion2);

            var valuesQuestion3 = new List<RadioButton> { radioButtonQuestion3Answer1,
                radioButtonQuestion3Answer2, radioButtonQuestion3Answer3,
                radioButtonQuestion3Answer4, radioButtonQuestion3Answer5};
            var priorityForm = additionalMethods.GetPriority(valuesQuestion3);

            var valuesQuestion4 = new List<RadioButton> { radioButtonQuestion4Answer1,
                radioButtonQuestion4Answer2, radioButtonQuestion4Answer3 };
            var timeToEducationForm = additionalMethods.GetTimeToEducation(valuesQuestion4);

            if (purposeForm == null)
            {
                MessageBox.Show(Properties.Resources.EmptyPurposeForm);
                Log.Warn(Properties.Resources.EmptyPurposeFormLog);
                return;
            }
            if (progSkillForm == null)
            {
                MessageBox.Show(Properties.Resources.EmptyProgSkillForm);
                Log.Warn(Properties.Resources.EmptyProgSkillFormLog);
                return;
            }
            if (priorityForm == null)
            {
                MessageBox.Show(Properties.Resources.EmptyPriorityForm);
                Log.Warn(Properties.Resources.EmptyPriorityFormLog);
                return;
            }
            if (timeToEducationForm == null)
            {
                MessageBox.Show(Properties.Resources.EmptyTimeForm);
                Log.Warn(Properties.Resources.EmptyTimeFormLog);
                return;
            }

            var purpose = await db.ProgrammingLanguagePurpose
            .FirstOrDefaultAsync(c => c.SelectedPurpose == purposeForm);

            var dbUser = await db.Users
            .Include(u => u.FormModel)
            .FirstOrDefaultAsync(u => u.Id == User.Id);

            if (dbUser.FormModel == null)
            {
                var form = new FormModel
                {
                    Id = Guid.NewGuid(),
                    ProgrammingSkillUser = progSkillForm,
                    TimeEducationInWeek = timeToEducationForm,
                    Priority = priorityForm,
                    UserId = dbUser.Id
                };

                if (purpose == null)
                {
                    var newPurpose = new ProgrammingLanguagePurposeModel
                    {
                        Id = Guid.NewGuid(),
                        SelectedPurpose = purposeForm,
                        Forms = new List<FormModel> { form },
                        FormId = form.Id
                    };

                    form.PurposeForm = newPurpose;
                    form.PurposeId = newPurpose.Id;

                    await db.AddAsync(newPurpose);
                }
                else
                {
                    form.PurposeForm = purpose;
                    form.PurposeId = purpose.Id;
                }

                MessageBox.Show(Properties.Resources.SuccessfulForm);

                Log.Info("Успешное заполнение анкеты");

                await db.AddAsync(form);
            }
            else
            {
                var form = dbUser.FormModel;

                form.ProgrammingSkillUser = progSkillForm;
                form.TimeEducationInWeek = timeToEducationForm;
                form.Priority = priorityForm;

                if (purpose == null)
                {
                    var newPurpose = new ProgrammingLanguagePurposeModel
                    {
                        Id = Guid.NewGuid(),
                        SelectedPurpose = purposeForm,
                        Forms = new List<FormModel> { form },
                        FormId = form.Id
                    };

                    form.PurposeForm = newPurpose;
                    form.PurposeId = newPurpose.Id;

                    await db.AddAsync(newPurpose);
                }
                else
                {
                    form.PurposeForm = purpose;
                    form.PurposeId = purpose.Id;
                }

                MessageBox.Show(Properties.Resources.SuccessfulEditForm);

                Log.Info("Успешное заполнение повторной анкеты");

                db.Update(form);
            }

            await db.SaveChangesAsync();
        }

        private void buttonAddForm_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.ButtonPaint(sender, e);
        }

        private void panelMainAddLanguage_Paint(object sender, PaintEventArgs e)
        {
            additionalMethods.Panel_Paint(panelMainAddForm);
        }
    }
}
