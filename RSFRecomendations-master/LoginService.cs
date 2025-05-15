namespace RSFRecomendations
{
    public class LoginService
    {
        private readonly MyDBContext _db;
        private readonly AdditionalMethodsClass _methods;

        public LoginService(MyDBContext dbContext, AdditionalMethodsClass methods)
        {
            _db = dbContext;
            _methods = methods;
        }

        /// <summary>
        /// Пытается войти по login/password. 
        /// Возвращает LoginResult.Success = true и найденного пользователя или false + сообщение об ошибке.
        /// </summary>
        public LoginResult Login(string login, string password)
        {
            // Проверка полей
            if (string.IsNullOrWhiteSpace(login))
                return LoginResult.Fail(Properties.Resources.EmptyLogin);

            if (login.Contains(" "))
                return LoginResult.Fail(Properties.Resources.NoContainsSpaceLogin);

            if (string.IsNullOrWhiteSpace(password))
                return LoginResult.Fail(Properties.Resources.EmptyPassword);

            if (password.Contains(" "))
                return LoginResult.Fail(Properties.Resources.NoContainsSpacePassword);

            // Поиск пользователя
            var user = _db.Users.FirstOrDefault(u => u.Login == login);
            if (user == null)
                return LoginResult.Fail(Properties.Resources.NoUser);

            // Проверка пароля
            var hashed = _methods.HashPassword(password, user.Salt);
            if (!hashed.SequenceEqual(user.Password))
                return LoginResult.Fail(Properties.Resources.WrongPassword);

            // Всё ок
            return LoginResult.Ok(user);
        }
    }
}
