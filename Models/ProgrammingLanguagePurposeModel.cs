using RSFRecomendations.Models;

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
/// Модель целей языка
/// </summary>
public class ProgrammingLanguagePurposeModel
{
    /// <summary>
    /// Уникальный ключ цели
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Связывающий ключ для языка
    /// </summary>
    public Guid ProgrammingLanguageId { get; set; }
    /// <summary>
    /// Связывающий ключ для анкеты
    /// </summary>
    public Guid FormId { get; set; }
    /// <summary>
    /// Список языков цели
    /// </summary>
    public ICollection<ProgrammingLanguageModel> ProgrammingLanguages { get; set; }
    /// <summary>
    /// Список анкет цели
    /// </summary>
    public ICollection<FormModel> Forms { get; set; }
    /// <summary>
    /// Сама цель
    /// </summary>
    public Purpose SelectedPurpose { get; set; }
}
