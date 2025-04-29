namespace RSFRecomendations.Models
{
    /// <summary>
    /// Модель Языка
    /// </summary>
    public class ProgrammingLanguageModel
    {
        public ProgrammingLanguageModel()
        {
            Id = Guid.NewGuid();
        }
        /// <summary>
        /// Универсальный ключ языка
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Название языка
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Область применения языка
        /// </summary>
        public string Purpose { get; set; }
        /// <summary>
        /// Сложность языка
        /// </summary>
        public string Difficulty { get; set; }
        /// <summary>
        /// Уровень программирования
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Список объектов UserProgrammingLanguage для связки
        /// </summary>
        public ICollection<UserProgrammingLanguageModel> UsersProgrammingLanguage { get; set; }
    }
}
