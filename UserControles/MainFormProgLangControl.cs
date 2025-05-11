using System.Collections.ObjectModel;
using System.Windows.Forms;
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
                Description = "Python — это высокоуровневый интерпретируемый язык программирования, известный своей простотой, " +
                "читаемым синтаксисом и широкой областью применения. Он идеально подходит для быстрого прототипирования, " +
                "написания скриптов и автоматизации. Благодаря огромному количеству библиотек и активному сообществу, " +
                "Python часто используется в научной среде, бизнесе и стартапах. Несмотря на универсальность, его скорость " +
                "исполнения ниже, чем у компилируемых языков.",
                Purpose = new List<string>()
                {
                    "Веб-разработка",
                    "ML/AI"
                },
                DifficultyLanguage = Difficulty.Easy,
                LevelLanguage = Level.Nocturnal,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            CSharp = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "C#",
                Description = "C# — объектно-ориентированный язык программирования, разработанный Microsoft. Он тесно связан " +
                "с платформой .NET и предлагает мощные средства разработки для создания производительных и масштабируемых " +
                "приложений. Язык отличается строгой типизацией, хорошей интеграцией с Windows-средой и отличной поддержкой " +
                "инструментов разработки. Он особенно популярен в корпоративной среде и при разработке игр на Unity.",
                Purpose = new List<string>()
                {
                    "Windows-приложения",
                    "Игры",
                    "Базы данных"
                },
                DifficultyLanguage = Difficulty.Medium,
                LevelLanguage = Level.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            JavaScript = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "JavaScript",
                Description = "JavaScript — интерпретируемый язык программирования, выполняемый в основном в браузере. " +
                "Он динамически типизируется, поддерживает как объектно-ориентированный, так и функциональный стиль программирования," +
                " и является неотъемлемой частью веб-разработки. Благодаря обширной экосистеме и низкому порогу входа, JavaScript широко " +
                "используется, но его гибкость может привести к неустойчивому коду без соблюдения строгих стандартов.",
                Purpose = new List<string>()
                {
                    "Веб-разработка",
                    "Мобильные и десктопные приложения"
                },
                DifficultyLanguage = Difficulty.Medium,
                LevelLanguage = Level.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            CPlus = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "C++",
                Description = "C++ — компилируемый язык программирования, являющийся развитием языка C и включающий " +
                "поддержку объектно-ориентированного программирования. Он предоставляет программисту детальный контроль " +
                "над памятью и ресурсами, что делает его одним из самых быстрых и мощных языков. Однако сложный синтаксис " +
                "и высокая вероятность ошибок делают его более требовательным к опыту разработчика.",
                Purpose = new List<string>()
                {
                    "Системное ПО",
                    "Игры",
                },
                DifficultyLanguage = Difficulty.Medium,
                LevelLanguage = Level.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };
            Java = new ProgrammingLanguageModel
            {
                Id = Guid.NewGuid(),
                Name = "Java",
                Description = "Java — строго типизированный объектно-ориентированный язык, работающий через виртуальную машину (JVM), " +
                "что обеспечивает его кроссплатформенность. Он известен своей надёжностью, безопасностью и масштабируемостью, что делает" +
                " его популярным выбором для разработки больших и долгоживущих программных систем. Несмотря на многословность синтаксиса, " +
                "Java сохраняет стабильную популярность в корпоративной среде.",
                Purpose = new List<string>()
                {
                    "Веб-разработка",
                    "Мобильные и десктопные приложения",
                    "Серверы"
                },
                DifficultyLanguage = Difficulty.Medium,
                LevelLanguage = Level.Intermediate,
                UsersProgrammingLanguage = new List<UserProgrammingLanguageModel>()
            };

            db.Add(Python);
            db.Add(CSharp);
            db.Add(JavaScript);
            db.Add(CPlus);
            db.Add(Java);
            db.SaveChanges();

            var items = new ObservableCollection<ProgrammingLanguageModel>()
            {
                Python,
                CSharp,
                JavaScript,
                CPlus,
                Java
            };

            listBoxFilteredLanguages.Items.Add(Python);
            listBoxFilteredLanguages.Items.Add(CSharp);
            listBoxFilteredLanguages.Items.Add(JavaScript);
            listBoxFilteredLanguages.Items.Add(CPlus);
            listBoxFilteredLanguages.Items.Add(Java);

            Log.Info("Переход к форме языков программирования");
        }

        private void listBoxFilteredLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilteredLanguages.SelectedItem is ProgrammingLanguageModel selectedItem)
            {
                tbDescriptionLanguage.Text = selectedItem.Description;
            }
        }
    }
}
