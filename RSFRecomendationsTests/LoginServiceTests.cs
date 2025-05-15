using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSFRecomendations;
using RSFRecomendations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSFRecomendations.Tests
{
    [TestClass()]
    public class LoginServiceTests
    {
        private LoginService service;
        private MyDBContext db;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<MyDBContext>()
                .UseInMemoryDatabase(databaseName: $"TestDb_{Guid.NewGuid()}")
                .Options;

            db = new MyDBContext(options);
            service = new LoginService(db, new AdditionalMethodsClass());
        }

        [TestMethod()]
        // Пустой логин
        public void EmptyLogin_ReturnsEmptyLoginError()
        {
            // arrange
            var login = "";
            var password = "ValidPassword1";

            // act
            // Логгируем с пустым логином
            var result = service.Login(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели логин!", result.Message);
        }

        [TestMethod()]
        // Пробел в логине
        public void LoginContainsSpace_ReturnsSpaceInLoginError()
        {
            // arrange
            var login = "user name";
            var password = "ValidPassword1";

            // act
            // Логгируем с пробелом в логине
            var result = service.Login(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Имя не может содержать пробелы!", result.Message);
        }

        [TestMethod()]
        // Пустой пароль
        public void EmptyPassword_ReturnsEmptyPasswordError()
        {
            // arrange 
            var login = "ValidLogin";
            var password = "";

            // act
            // Логгируем с пустым паролем
            var result = service.Login(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели пароль или ввели только пробелы!", result.Message);

        }

        [TestMethod()]
        // Пароль с пробелом
        public void PasswordContainsSpace_ReturnsSpaceInPasswordError()
        {
            // arrange 
            var login = "ValidLogin";
            var password = "Invalid Password";

            // act
            // Логгируем с пробелом в пароле
            var result = service.Login(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пароль не может содержать пробелы!", result.Message);
        }

        [TestMethod()]
        // Нет пользователя в базе данных
        public void NoUser_ReturnsNoUserError()
        {
            // arrange 
            var login = "ValidLogin";
            var password = "ValidPassword";

            // act 
            // Логгируем с валидными данными, получаем 
            var result = service.Login(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пользователя с таким логином не существует!", result.Message);
        }

        [TestMethod()]
        // Неправильный пароль (Здесь же нужно писать существующий логин, которые есть в бд да? ChatGPT? )
        public void WrongPassword_ReturnsWrongPasswordError()
        {
            // arrange
            var login = "nikita";
            var correctPassword = "12345678";
            var wrongPassword = "12345679";
            var salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            var hashedPassword = new AdditionalMethodsClass().HashPassword(correctPassword, salt);

            db.Users.Add(new UserModel
            {
                Id = Guid.NewGuid(),
                Login = login,
                Email = "test@example.com",
                Password = hashedPassword,
                Salt = salt
            });
            db.SaveChanges();

            // act
            var result = service.Login(login, wrongPassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы ввели не правильный пароль!", result.Message);
        }

        [TestMethod()]
        // Корректные логин+пароль 
        public void ValidLoginAndPassword_ReturnsSuccess()
        {
            // arrange
            var login = "nikita";
            var password = "12345678";
            var salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            var hashedPassword = new AdditionalMethodsClass().HashPassword(password, salt);

            db.Users.Add(new UserModel
            {
                Id = Guid.NewGuid(),
                Login = login,
                Email = "test@example.com",
                Password = hashedPassword,
                Salt = salt
            });
            db.SaveChanges();

            // act
            var result = service.Login(login, password);

            // assert
            Assert.IsTrue(result.Success);
            Assert.AreEqual(string.Empty, result.Message);
        }

        [TestMethod]
        // NULL в login
        public void NullLogin_ReturnsEmptyLoginError()
        {
            // arrange 
            string login = null;
            var password = "validpassword";

            // act 
            // Пытаемся залогиниться при login = null
            var result = service.Login(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели логин!", result.Message);
        }

        [TestMethod]
        // NULL в password
        public void NullPassword_ReturnsEmptyPasswordError()
        {
            // arrange 
            var login = "validuser";
            string password = null;

            // act 
            // Пытаемся залогиниться при password = null
            var result = service.Login("user", null);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели пароль или ввели только пробелы!", result.Message);
        }

        [TestMethod]
        // login чувствителен к регистру: User != user
        public void LoginCaseSensitive_ReturnsNoUserError()
        {
            // arrange
            // пользователь с логином User
            var loginDB = "User";
            var password = "12345678";

            var salt = new byte[16];
            RandomNumberGenerator.Fill(salt);
            var hashedPassword = new AdditionalMethodsClass().HashPassword(password, salt);

            db.Users.Add(new UserModel
            {
                Id = Guid.NewGuid(),
                Login = loginDB,
                Email = "testma@gmail.com",
                Password = hashedPassword,
                Salt = salt
            });
            db.SaveChanges();

            var login = "user";

            // act
            // пробуем войти с user
            var result = service.Login(login, password);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пользователя с таким логином не существует!", result.Message);
        }
    }
}