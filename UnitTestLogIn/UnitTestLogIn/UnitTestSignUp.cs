using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogIn;
using MySql.Data.MySqlClient;
namespace UnitTestLogIn
{
    [TestClass]
    public class UnitTestSignUp
    {
        private UsersManager _usersManager;
        [TestInitialize]
        public void Init()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodor;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            _usersManager = new UsersManager(_conn);
        }
        [TestMethod]
        public void ValidTest()
        {

            Assert.AreEqual(1, _usersManager.signUp("Nume", "Prenume", "mail@mail.com", "parola", "parola"));

        }
        [TestMethod]
        public void NotExistingDataBase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            UsersManager _usersManager = new UsersManager(_conn);
            Assert.AreEqual(-2, _usersManager.signUp("Nume", "Prenume", "mail@mail.com", "parola", "parola"));

        }
        [TestMethod]
        public void EmptyName()
        {

            Assert.AreEqual(-1, _usersManager.signUp("", "Prenume", "mail@mail.com", "parola", "parola"));

        }
        [TestMethod]
        public void EmptySurname()
        {

            Assert.AreEqual(-1, _usersManager.signUp("Nume", "", "mail@mail.com", "parola", "parola"));

        }
        [TestMethod]
        public void IncorrectMailFormat()
        {

            Assert.AreEqual(0, _usersManager.signUp("Nume", "Prenume", "mailmail.com", "parola", "parola"));

        }
        [TestMethod]
        public void IncorrectMailFormat2()
        {

            Assert.AreEqual(0, _usersManager.signUp("Nume", "Prenume", "mail@mailcom", "parola", "parola"));

        }
        [TestMethod]
        public void IncorrectMailFormatAndEmptyName()
        {

            Assert.AreEqual(-1, _usersManager.signUp("", "Prenume", "mail@mailcom", "parola", "parola"));

        }
        [TestMethod]
        public void InvalidVerifyPassword()
        {

            Assert.AreEqual(-1, _usersManager.signUp("", "Prenume", "mail@mailcom", "parola", "parol"));

        }
        [TestMethod]
        public void EmptyMail()
        {

            Assert.AreEqual(-1, _usersManager.signUp("Nume", "Prenume", "", "parola", "parola"));

        }
        [TestMethod]
        public void DuplicateMail()
        {

            Assert.AreEqual(0, _usersManager.signUp("Nume", "Prenume", "colipcateodor@gmail.com", "parola", "parola"));

        }
        [TestMethod]
        public void DuplicateMailAndNotExistingDatabase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            UsersManager _usersManager = new UsersManager(_conn);
            Assert.AreEqual(-2, _usersManager.signUp("Nume", "Prenume", "colipcateodor@gmail.com", "parola", "parola"));

        }
        [TestMethod]
        public void AlreadyExistingUser()
        {

            Assert.AreEqual(0, _usersManager.signUp("Colipca", "Teodor", "colipcateodor@gmail.com", "parola", "parola"));

        }
    }
}
