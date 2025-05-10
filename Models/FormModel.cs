namespace RSFRecomendations.Models
{
    /// <summary>
    /// Модель Анкеты
    /// </summary>
    public class FormModel
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
        /// Перечисление умения программировать
        /// </summary>
        public enum ProgrammingSkill
        {
            /// <summary>
            /// Начинающий
            /// </summary>
            Nocturnal,
            /// <summary>
            /// Средний
            /// </summary>
            Intermediate,
            /// <summary>
            /// Продвинутый
            /// </summary>
            Advanced
        }
        /// <summary>
        /// Уникальный ключ анкеты
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Область применения языка
        /// </summary>
        public List<string> Purpose { get; set; }

        /// <summary>
        /// Сложность языка
        /// </summary>
        public Difficulty DifficultyForm { get; set; }

        /// <summary>
        /// Уровень программирования пользователя
        /// </summary>
        public ProgrammingSkill ProgrammingSkillUser { get; set; }

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
