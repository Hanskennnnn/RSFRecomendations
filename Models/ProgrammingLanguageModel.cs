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
