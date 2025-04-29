namespace RSFRecomendations.Models
{
    /// <summary>
    /// Модель Анкеты
    /// </summary>
    public class FormModel
    {
        public FormModel()
        {
            Id = Guid.NewGuid();
        }
        /// <summary>
        /// Уникальный ключ анкеты
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Область применения языка
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Сложность языка
        /// </summary>
        public string Difficulty { get; set; }

        /// <summary>
        /// Уровень программирования пользователя
        /// </summary>
        public string ProgrammingSkill { get; set; }

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
