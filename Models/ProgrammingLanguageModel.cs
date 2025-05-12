namespace RSFRecomendations.Models
{

    /// <summary>
    /// Перечисление сложности языка
    /// </summary>
    public enum Difficulty
    {
        /// <summary>
        /// Легкий
        /// </summary>
        Easy,
        /// <summary>
        /// Средний
        /// </summary>
        Medium, 
        /// <summary>
        /// Сложный
        /// </summary>
        Difficult
    }

    /// <summary>
    /// Перечисление целей языка
    /// </summary>
    public enum Purpose
    {
        /// <summary>
        /// Веб-программирование
        /// </summary>
        WebDevelopment,
        /// <summary>
        /// Игры
        /// </summary>
        GameDevelopment,
        /// <summary>
        /// Микросервисы
        /// </summary>
        Microservices,
        /// <summary>
        /// Приложения
        /// </summary>
        ApplicationDevelopment,
        /// <summary>
        /// Образование и быстрое прототипирование
        /// </summary>
        EducationAndRapidPrototyping,
        /// <summary>
        /// Серверная разработка
        /// </summary>
        ServerSideDevelopment,
        /// <summary>
        /// Разработка приложений под Windows (WPF, WinForms)
        /// </summary>
        WindowsApplicationDevelopment,
        /// <summary>
        /// Обработка данных и автоматизация на платформе .NET
        /// </summary>
        NETDataProcessingAndAutomation,
        /// <summary>
        /// Cистемное программирование (драйверы, ОС)
        /// </summary>
        SystemsProgramming,
        /// <summary>
        /// Встроенные системы (Embedded)
        /// </summary>
        EmbeddedSystems,
        /// <summary>
        /// Финансовое ПО и торговые системы
        /// </summary>
        FinancialAndTradingSoftware,
        /// <summary>
        /// Data Science и анализ данных
        /// </summary>
        DataScienceAndDataAnalysis,
        /// <summary>
        /// Машинное обучение / ИИ
        /// </summary>
        MachineLearningAndAI,
        /// <summary>
        /// Скрипты и автоматизация
        /// </summary>
        ScriptingAndAutomation,
        /// <summary>
        /// Разработка CLI-инструментов
        /// </summary>
        CLIToolDevelopment,
        /// <summary>
        /// Мобильная разработка (Android)
        /// </summary>
        MobileDevelopmentInAndroid,
        /// <summary>
        /// Разработка PWA и SPA
        /// </summary>
        PWAAndSPADevelopment,
        /// <summary>
        /// Интерактивность в браузере
        /// </summary>
        BrowserInteractivity,
        /// <summary>
        /// Полный стек (Full Stack) с MongoDB, Express и пр.
        /// </summary>
        FullStackDevelopment
    }

    /// <summary>
    /// Модель Языка
    /// </summary>
    public class ProgrammingLanguageModel
    {
        /// <summary>
        /// Универсальный ключ языка
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название языка
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Описание языка
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Область применения языка
        /// </summary>
        public ICollection<ProgrammingLanguagePurposeModel> Purposes { get; set; }
        /// <summary>
        /// Фото языка
        /// </summary>
        public byte[]? Image { get; set; }
        /// <summary>
        /// Сложность языка
        /// </summary>
        public Difficulty? DifficultyLanguage { get; set; }
        /// <summary>
        /// Список объектов UserProgrammingLanguage для связки
        /// </summary>
        public ICollection<UserProgrammingLanguageModel> UsersProgrammingLanguage { get; set; }

        /// <summary>
        /// Переопределение метода ToString для вывода имени
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
