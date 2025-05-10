namespace RSFRecomendations.Models
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Униыерсальный ключ пользователя
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Пароль пользователся
        /// </summary>
        public byte[] Password { get; set; }
        /// <summary>
        /// Уникальная соль для хэширования пароля
        /// </summary>
        public byte[] Salt { get; set; }
        public FormModel FormModel { get; set; }
        /// <summary>
        /// Список объектов UserProgrammingLanguage для связки
        /// </summary>
        public ICollection<UserProgrammingLanguageModel> UsersProgrammingLanguage { get; set; }
    }
}
