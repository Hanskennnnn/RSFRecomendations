namespace RSFRecomendations.Models
{
    /// <summary>
    /// Модель пользователя языка
    /// </summary>
    public class UserProgrammingLanguageModel
    {
        /// <summary>
        /// Внешний ключ User
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Объект User для связки
        /// </summary>
        public UserModel User { get; set; }

        /// <summary>
        /// Внешний ключ ProgramminLanguage
        /// </summary>
        public Guid ProgramminLanguageId { get; set; }

        /// <summary>
        /// Объект ProgrammingLanguage для связки
        /// </summary>
        public ProgrammingLanguageModel ProgrammingLanguage { get; set; }
    }
}
