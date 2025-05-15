namespace RSFRecomendations
{
    /// <summary>
    /// Результат попытки регистрации.
    /// </summary>
    public class RegistrationResult
    {
        /// <summary> true, если регистрация прошла успешно; false при любой ошибке. </summary>
        public bool Success { get; }

        /// <summary> Текст сообщения об ошибке или успешной регистрации. </summary>
        public string Message { get; }

        private RegistrationResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        /// <summary> Создать результат с ошибкой и текстом message. </summary>
        public static RegistrationResult Fail(string message)
            => new RegistrationResult(false, message);

        /// <summary> Создать результат успешной регистрации с необязательным текстом. </summary>
        public static RegistrationResult Ok(string message = "")
            => new RegistrationResult(true, message);
    }
}
