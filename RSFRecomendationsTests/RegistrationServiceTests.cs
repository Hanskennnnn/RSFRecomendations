using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using RSFRecomendations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSFRecomendations.Models;

namespace RSFRecomendations.Tests
{
    [TestClass()]
    public class RegistrationServiceTests
    {
        private RegistrationService service;
        private MyDBContext db;

        [TestInitialize]
        public void Setup()
        {
            // 1) Настраиваем InMemory‐базу с уникальным именем
            var options = new DbContextOptionsBuilder<MyDBContext>()
                .UseInMemoryDatabase($"TestDb_{Guid.NewGuid()}")
                .Options;

            db = new MyDBContext(options);
            service = new RegistrationService(db, new AdditionalMethodsClass());
        }

        [TestMethod()]
        // Пустой логин 
        public void EmptyLogin_ReturnsEmptyLoginError()
        {
            // arrange
            var login = "";
            var email = "nikita@gmail.com";
            var password = "ValidPassword1";
            var repeatpassword = "ValidPassword1";

            // act
            // Пытаемся зарегистрироваться с пустым логином
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели логин!", result.Message);
        }

        [TestMethod()]
        // Неправильный формат логина
        public void InvalidFormatLogin_ReturnsIncorrectLoginNumError()
        {
            // arrange
            var login = "1234";
            var email = "nikita@gmail.com";
            var password = "ValidPassword1";
            var repeatpassword = "ValidPassword1";

            // act 
            // Пытаемся зарегистрироваться с некорректным логином
            var result = service.Register(login, email, password, repeatpassword);

            // assert 
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Некорректный логин", result.Message);
        }

        [TestMethod()]
        // Слишком короткий логин
        public void InvalidLoginChars_ReturnsIncorrectLoginError()
        {
            // arrange 
            var login = "ab";
            var email = "nikita@gmail.com";
            var password = "ValidPassword1";
            var repeatpassword = "ValidPassword1";

            // act 
            // Пытаемся зарегистрироваться с коротким логином
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Некорректный логин", result.Message);
        }

        [TestMethod()]
        // Логин с пробелом 
        public void LoginContainsSpace_ReturnsNoContainsSpaceLoginError()
        {
            // arrange 
            var login = "user name";
            var email = "nikita@gmail.com";
            var password = "ValidPassword1";
            var repeatpassword = "ValidPassword1";

            // act
            // Пытаемся зарегистрироваться с пробелом в логине
            var result = service.Register(login, email, password, repeatpassword);

            // assert 
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Некорректный логин", result.Message);
        }

        [TestMethod()]
        // Пустой email 
        public void EmptyEmail_ReturnsEmptyEmailError()
        {
            // arrange
            var login = "validuser";
            var email = "";
            var password = "ValidPassword1";
            var repeatpassword = "ValidPassword1";

            // act 
            // Пытаемся зарегистрироваться с пустым email
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели почту!", result.Message);
        }

        [TestMethod()]
        // Некорректный email
        public void InvalidEmailFormat_ReturnsIncorrectMailError()
        {
            // arrange 
            var login = "validuser";
            var email = "not-an-email";
            var password = "ValidPassword1";
            var repeatpassword = "ValidPassword1";

            // act
            // Пытаемся зарегистрироваться с некорректным email
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Почта должна быть вида \"____@__.__\" и до @ должно быть минимум 4 символа, после @ и до . минимум 3 символа, после . минимум 2 символа", result.Message);
        }

        [TestMethod()]
        // Пустой пароль
        public void EmptyPassword_ReturnsEmptyPasswordError()
        {
            // arrange 
            var login = "validuser";
            var email = "nikita@gmail.com";
            var password = "";
            var repeatpassword = "";

            // act 
            // Пытаемся зарегистрироваться с пустым паролем
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели пароль или ввели только пробелы!", result.Message);
        }

        [TestMethod()]
        // Пароль содержит пробел
        public void PasswordContainsSpace_ReturnsNoContainsSpacePasswordError()
        {
            // arrange
            var login = "validuser";
            var email = "nikita@gmail.com";
            var password = "Valid Password1";
            var repeatpassword = "Valid Password1";

            // act 
            // Пытаемся зарегистрироваться с пробелом в пароле
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пароль не может содержать пробелы!", result.Message);
        }

        [TestMethod()]
        // Пустой повтор пароля
        public void EmptyRepeatPassword_ReturnsEmptyRepeatPasswordError()
        {
            // arrange
            var login = "validuser";
            var email = "nikita@gmail.com";
            var password = "ValidPassword1";
            var repeatpassword = "";

            // act 
            // Пытаемся зарегистрироваться с пустым повторным паролем
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Вы не ввели повторный пароль или ввели только пробелы!", result.Message);
        }

        [TestMethod]
        // Повторный пароль с пробелом
        public void RepeatPasswordContainsSpace_ReturnsNoContainsSpacePassword2Error()
        {
            // arrange
            var login = "validuser";
            var email = "nikita@gmail.com";
            var password = "ValidPassword1";
            var repeatpassword = "Valid Password1";

            // act 
            // Пытаемся зарегистрироваться с пробелом в повторном пароле
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Повторный пароль не может содержать пробелы!", result.Message);
        }

        [TestMethod()]
        // Пароли не совпадают
        public void PasswordsDoNotMatch_ReturnsPasswordsDontMatchError()
        {
            // arrange
            var login = "validuser";
            var email = "nikita@gmail.com";
            var password = "ValidPassword1";
            var repeatpassword = "ValidPassword2";

            // act
            // Пытаемся зарегистрироваться с несовпадающими паролями
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Ваши пароли не совпадают!", result.Message);
        }

        [TestMethod()]
        // Слишком короткий пароль (<8)
        public void ShortPassword_ReturnsLengthPasswordError()
        {
            // arrange 
            var login = "validuser";
            var email = "nikita@gmail.com";
            var password = "Inv";
            var repeatpassword = "Inv";

            // act 
            // Пытаемся зарегистрироваться с коротким паролем
            var result = service.Register(login, email, password, repeatpassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("В пароле должно быть минимум 8 символов!", result.Message);
        }

        [TestMethod]
        // Логин уже существует 
        public void ExistingLogin_ReturnsUserExistsRegLoginError()
        {
            // arrange: заранее добавляем пользователя с логином "taken"
            db.Users.Add(new UserModel
            {
                Id = Guid.NewGuid(),
                Login = "taken",
                Email = "already@gmail.com",
                Password = new byte[32],
                Salt = new byte[16]
            });
            db.SaveChanges();

            var login = "taken";
            var email = "newemail@gmail.com";
            var password = "ValidPass1";
            var repeatPassword = "ValidPass1";

            // act
            // Пытаемся зарегестрировать пользователя, который уже существует в базе данных
            var result = service.Register(login, email, password, repeatPassword);

            // assert 
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пользователь с таким логином уже существует!", result.Message);
        }

        [TestMethod]
        // Email уже существует
        public void ExistingEmail_ReturnsUserExistsRegEmailError()
        {
            // arrange также с почтой already@gmail.com
            db.Users.Add(new UserModel
            {
                Id = Guid.NewGuid(),
                Login = "validuser1",
                Email = "already@gmail.com",
                Password = new byte[32],
                Salt = new byte[16]
            });
            db.SaveChanges();

            var login = "validuser2";
            var email = "already@gmail.com";
            var password = "ValidPass1";
            var repeatPassword = "ValidPass1";

            // act 
            // Пытаемся зарегестрировать пользователя, у которогр почта существует у другого пользователя
            var result = service.Register(login, email, password, repeatPassword);

            // assert
            Assert.IsFalse(result.Success);
            Assert.AreEqual("Пользователь с такой почтой уже существует", result.Message);
        }

        [TestMethod]
        // Успешная регистрация → добавляет пользователя и возвращает SuccessfulRegistration
        public void SuccessfulRegistration_AddsUserAndReturnsSuccess()
        {
            // arrange
            var login = "validuser1";
            var email = "nikita@gmail.com";
            var password = "ValidPass1";
            var repeatPassword = "ValidPass1";

            // act
            // Успешно регистрируем пользователя в БД
            var result = service.Register(login, email, password, repeatPassword);

            // assert
            Assert.IsTrue(result.Success);
            Assert.AreEqual("Регистрация прошла успешна!", result.Message);

            var saved = db.Users.SingleOrDefault(u => u.Login == login);
            Assert.IsNotNull(saved, "Пользователь должен сохраниться в БД");
            Assert.AreEqual(email, saved.Email);
        }
    }
}

