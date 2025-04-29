namespace RSFRecomendations.Models
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Конструктор для присвоения уникального Id
        /// </summary>
        public UserModel()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Униыерсальный ключ пользователя
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль пользователся
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Объект FormModel для связки
        /// </summary>
        public FormModel FormModel { get; set; }
        /// <summary>
        /// Список объектов UserProgrammingLanguage для связки
        /// </summary>
        public ICollection<UserProgrammingLanguageModel> UsersProgrammingLanguage { get; set; }
    }
}
