using RSFRecomendations.Models;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace RSFRecomendations
{
    /// <summary>
    /// Сервис регистрации пользователей.
    /// </summary>
    public class RegistrationService
    {
        private readonly MyDBContext _db;
        private readonly AdditionalMethodsClass _methods;

        /// <summary>
        /// Конструктор: принимает контекст базы данных и вспомогательный класс для валидации и хеширования.
        /// </summary>
        public RegistrationService(MyDBContext dbContext, AdditionalMethodsClass methods)
        {
            _db = dbContext;
            _methods = methods;
        }

        /// <summary>
        /// Пытается зарегистрировать нового пользователя.
        /// Возвращает Fail(...) при первой же найденной ошибке или Ok(...) при полном успехе.
        /// </summary>
        public RegistrationResult Register(
            string login,
            string email,
            string password,
            string repeatPassword)
        {
            // Проверка логина
            // Если пустой или равен плейсхолдеру Mask (EnterLogin)
            if (string.IsNullOrWhiteSpace(login) || login == Properties.Resources.EnterLogin)
                return RegistrationResult.Fail(Properties.Resources.EmptyLogin);

            // Если формат не начинает с буквы и состоит не только из A–Z,a–z,0–9
            if (!Regex.IsMatch(login, @"^[a-zA-Z][a-zA-Z0-9]*$"))
                return RegistrationResult.Fail(Properties.Resources.IncorrectLoginNum);

            // Если не проходит базовую валидацию (длина >=3, только латиница и цифры)
            if (!_methods.IsValidLogin(login))
                return RegistrationResult.Fail(Properties.Resources.IncorrectLogin);

            // Если содержит пробел
            if (login.Contains(" "))
                return RegistrationResult.Fail(Properties.Resources.NoContainsSpaceLogin);

            // Проверка email
            if (string.IsNullOrWhiteSpace(email) || email == Properties.Resources.EnterEmail)
                return RegistrationResult.Fail(Properties.Resources.EmptyEmail);

            if (!_methods.IsValidEmail(email))
                return RegistrationResult.Fail(Properties.Resources.IncorrectMail);

            // Проверка паролей
            if (string.IsNullOrWhiteSpace(password) || password == Properties.Resources.EnterPassword)
                return RegistrationResult.Fail(Properties.Resources.EmptyPassword);

            if (password.Contains(" "))
                return RegistrationResult.Fail(Properties.Resources.NoContainsSpacePassword);

            if (string.IsNullOrWhiteSpace(repeatPassword) || repeatPassword == Properties.Resources.EnterRepeatPassword)
                return RegistrationResult.Fail(Properties.Resources.EmptyRepeatPassword);

            if (repeatPassword.Contains(" "))
                return RegistrationResult.Fail(Properties.Resources.NoContainsSpacePassword2);

            if (password != repeatPassword)
                return RegistrationResult.Fail(Properties.Resources.PasswordsDontMatch);

            if (password.Length < 8)
                return RegistrationResult.Fail(Properties.Resources.LengthPassword);

            // Проверка существующего логина
            if (_db.Users.FirstOrDefault(u => u.Login == login) != null)
                return RegistrationResult.Fail(Properties.Resources.UserExistsRegLogin);

            // Проверка существующего email 
            if (_db.Users.FirstOrDefault(u => u.Email == email) != null)
                return RegistrationResult.Fail(Properties.Resources.UserExistsRegEmail);

            // Генерация соли для хеширования пароля 
            var salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            // Хеширование
            var hashed = _methods.HashPassword(password, salt);

            // Создание и сохранение модели пользователя
            var user = new UserModel
            {
                Id    = Guid.NewGuid(),
                Login = login,
                Email = email,
                Image = _methods.ImageToBytes(Properties.Resources.Аватарка),
                Password = hashed,
                Salt     = salt
            };

            _db.Users.Add(user);
            _db.SaveChanges();

            // Возвращаем успешный результат
            return RegistrationResult.Ok(Properties.Resources.SuccessfulRegistration);
        }
    }
}
