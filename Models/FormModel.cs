
namespace RSFRecomendations.Models
{
    /// <summary>
    /// Перечисление умения программировать
    /// </summary>
    public enum ProgrammingSkill
    {
        /// <summary>
        /// Новичок
        /// </summary>
        Nocturnal,

        /// <summary>
        /// Базовый
        /// </summary>
        Intermediate,

        /// <summary>
        /// Продвинутый
        /// </summary>
        Advanced
    }

    public enum ProgrammingLanguagePriority
    {
        /// <summary>
        /// Простота и понятность
        /// </summary>
        Simplicity,

        /// <summary>
        /// Возможность найти работу
        /// </summary>
        JobOpportunities,

        /// <summary>
        /// Универсальность
        /// </summary>
        Versatility,

        /// <summary>
        /// Много учебных материалов
        /// </summary>
        LearningResources,

        /// <summary>
        /// Быстродействие
        /// </summary>
        Performance
    }

    /// <summary>
    /// Время обучения в неделю
    /// </summary>
    public enum TimeToEducation
    {
        /// <summary>
        /// Меньше 3 часов
        /// </summary>
        LessThanThreeHours,   

        /// <summary>
        /// От 3 до 5 часов
        /// </summary>
        ThreeToFiveHours, 

        /// <summary>
        /// От 6 до 10 часов и больше
        /// </summary>
        SixToTenPlusHours  
    }

    /// <summary>
    /// Модель Анкеты
    /// </summary>
    public class FormModel
    {
        /// <summary>
        /// Уникальный ключ анкеты
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Ключ связки с целью
        /// </summary>
        public Guid PurposeId { get; set; }

        /// <summary>
        /// Область применения языка
        /// </summary>
        public ProgrammingLanguagePurposeModel PurposeForm { get; set; }

        /// <summary>
        /// Сложность языка
        /// </summary>
        public Difficulty DifficultyForm { get; set; }

        /// <summary>
        /// Уровень программирования пользователя
        /// </summary>
        public ProgrammingSkill ProgrammingSkillUser { get; set; }

        /// <summary>
        /// Время на обучение в неделю
        /// </summary>
        public TimeToEducation TimeEducationInWeek { get; set; }

        /// <summary>
        /// Объект User для связки 
        /// </summary>
        public UserModel User { get; set; }

        /// <summary>
        /// Внешний ключ User
        /// </summary>
        public Guid UserId { get; set; }
    }
}
