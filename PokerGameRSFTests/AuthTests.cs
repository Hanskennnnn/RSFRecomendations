using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading.Tasks;
using PokerGameRSF;
using Microsoft.EntityFrameworkCore;
namespace PokerGameRSFTests
{
    [TestClass]
    public class AuthServiceTests
    {
        private MyDbContext _context;
        private RegistrationService _registrationService;
        private LoginService _loginService;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _context = new MyDbContext(options);
            var helper = new AuthHelper();
            _registrationService = new RegistrationService(_context, helper);
            _loginService = new LoginService(_context, helper);
        }

        [TestMethod]
        // Пустой логин
        public async Task Login_EmptyLogin_ReturnsError()
        {
            // arrange
            var login = "";
            var password = "ValidPassword";

            // act
            var result = await _loginService.LoginAsync(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Логин не может быть пустым", result.Message);
        }

        [TestMethod]
        // Пустой пароль
        public async Task Login_EmptyPassword_ReturnsError()
        {
            // arrange
            var login = "ValidUser";
            var password = "";

            // act
            var result = await _loginService.LoginAsync(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пароль не может быть пустым", result.Message);
        }

        [TestMethod]
        // Пользователь не найден
        public async Task Login_UserNotFound_ReturnsError()
        {
            // arrange
            var login = "NonExistent";
            var password = "ValidPassword";

            // act
            var result = await _loginService.LoginAsync(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Такого пользователя не существует", result.Message);
        }

        [TestMethod]
        // Неверный пароль
        public async Task Login_WrongPassword_ReturnsError()
        {
            // arrange
            await _registrationService.RegisterAsync("user", "user@mail.com", "Password123", "Password123");

            // act
            var result = await _loginService.LoginAsync("user", "WrongPassword");

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Введён некорректный пароль", result.Message);
        }

        [TestMethod]
        // Успешный логин
        public async Task Login_CorrectCredentials_ReturnsSuccess()
        {
            // arrange
            await _registrationService.RegisterAsync("user", "user@mail.com", "Password123", "Password123");

            // act
            var result = await _loginService.LoginAsync("user", "Password123");

            // assert
            Assert.IsTrue(result.Success);
            Assert.AreEqual("", result.Message);
            Assert.IsNotNull(result.User);
        }

        [TestMethod]
        // Успешная регистрация
        public async Task Register_ValidInput_ReturnsSuccess()
        {
            // arrange
            var login = "NewUser";
            var email = "new@mail.com";
            var password = "Password123";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsTrue(result.Success);
            Assert.AreEqual("Регистрация прошла успешно", result.Message);
        }

        [TestMethod]
        // Повторный email
        public async Task Register_DuplicateEmail_ReturnsError()
        {
            // arrange
            await _registrationService.RegisterAsync("user1", "dup@mail.com", "Password123", "Password123");

            // act
            var result = await _registrationService.RegisterAsync("user2", "dup@mail.com", "Password123", "Password123");

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Такой пользователь уже зарегистрирован", result.Message);
        }

        [TestMethod]
        // Короткий логин
        public async Task Register_ShortLogin_ReturnsError()
        {
            // arrange
            var login = "abc";
            var email = "short@mail.com";
            var password = "Password123";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("В логине должно быть не менее 4 символов", result.Message);
        }

        [TestMethod]
        // Неверный формат почты
        public async Task Register_InvalidEmailFormat_ReturnsError()
        {
            // arrange
            var login = "user";
            var email = "mail.com";
            var password = "Password123";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("В почте должен обязательно содержаться символ @", result.Message);
        }

        [TestMethod]
        // Пароли не совпадают
        public async Task Register_PasswordsMismatch_ReturnsError()
        {
            // arrange
            var login = "user";
            var email = "mail@mail.com";
            var password = "Password123";
            var repeat = "Password321";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, repeat);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пароли не совпадают", result.Message);
        }

        [TestMethod]
        // Короткий пароль
        public async Task Register_ShortPassword_ReturnsError()
        {
            // arrange
            var login = "user";
            var email = "mail@mail.com";
            var password = "short";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("В пароле должно быть не менее 8 символов", result.Message);
        }

        [TestMethod]
        // Недопустимые символы в пароле
        public async Task Register_InvalidPasswordSymbols_ReturnsError()
        {
            // arrange
            var login = "user";
            var email = "mail@mail.com";
            var password = "pass@word";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.IsTrue(result.Message.Contains("В пароле разрешены только такие символы"));
        }
        [TestMethod]
        // Email содержит несколько точек и @ в неправильной позиции
        public async Task Register_EmailDotBeforeAt_ReturnsError()
        {
            // arrange
            var login = "validuser";
            var email = "mail.mail@email";
            var password = "Password123";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Некорректно введена почта", result.Message);
        }

        [TestMethod]
        // Email с пустыми частями при разбиении
        public async Task Register_EmailWithEmptyParts_ReturnsError()
        {
            // arrange
            var login = "validuser";
            var email = "@.";
            var password = "Password123";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Некорректно введена почта", result.Message);
        }

        [TestMethod]
        // Email начинается с @
        public async Task Register_EmailStartsWithAt_ReturnsError()
        {
            // arrange
            var login = "validuser";
            var email = "@domain.com";
            var password = "Password123";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("В почте символ @ не должен стоять в начале", result.Message);
        }

        [TestMethod]
        // Email содержит два символа @
        public async Task Register_EmailWithTwoAts_ReturnsError()
        {
            // arrange
            var login = "validuser";
            var email = "mail@@domain.com";
            var password = "Password123";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("В почте должен быть 1 символ @", result.Message);
        }

        [TestMethod]
        // Пароль содержит допустимые символы на границе
        public async Task Register_PasswordWithMaxAllowedChars_ReturnsSuccess()
        {
            // arrange
            var login = "borderline";
            var email = "border@mail.com";
            var password = "12345678";

            // act
            var result = await _registrationService.RegisterAsync(login, email, password, password);

            // assert
            Assert.IsTrue(result.Success);
        }

        [TestMethod]
        // Попытка войти после успешной регистрации
        public async Task Login_AfterRegistration_ReturnsSuccess()
        {
            // arrange
            var login = "newuser";
            var email = "newuser@mail.com";
            var password = "Password123";
            await _registrationService.RegisterAsync(login, email, password, password);

            // act
            var result = await _loginService.LoginAsync(login, password);

            // assert
            Assert.IsTrue(result.Success);
            Assert.AreEqual("", result.Message);
        }
    }
}