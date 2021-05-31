/**************************************************************************
 *                                                                        *
 *  File:        UnitTestLogare.cs                                        *
 *  Autor:       Teodor Colipca                                           *         
 *  Functionalitate:    Clasa pentru testarea modului de Log in           *
 **************************************************************************/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogIn;
using MySql.Data.MySqlClient;
namespace UnitTestLogIn
{
    [TestClass]
    public class UnitTestLogare
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

            Assert.AreEqual(1, _usersManager.Logare("colipcateodor@gmail.com", "mama"));

        }
        [TestMethod]
        public void NotExistingUserTest()
        {

            Assert.AreEqual(-1, _usersManager.Logare("aaa", "mama"));
        }
        [TestMethod]
        public void EmptyMail()
        {

            Assert.AreEqual(-1, _usersManager.Logare("", "mama"));
        }
        [TestMethod]
        public void EmptyPassword()
        {

            Assert.AreEqual(-1, _usersManager.Logare("aa", ""));
        }
        [TestMethod]
        public void NotExistingDataBase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            UsersManager _usersManager = new UsersManager(_conn);
            Assert.AreEqual(-2, _usersManager.Logare("colipcateodor@gmail.com", "mama"));
        }
        [TestMethod]
        public void ValidTest2()
        {

            Assert.AreEqual(2, _usersManager.Logare("neculaclaudiu@gmail.com", "tata"));
        }
        [TestMethod]
        public void EmptyPasswordAndMail()
        {

            Assert.AreEqual(-1, _usersManager.Logare("", ""));
        }
        [TestMethod]
        public void EmptyPasswordMailAndNotExistingDatabase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            UsersManager _usersManager = new UsersManager(_conn);
            Assert.AreEqual(-2, _usersManager.Logare("", ""));
        }
        [TestMethod]
        public void NotExistingUserTestAndNotExistingDatabase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            UsersManager _usersManager = new UsersManager(_conn);
            Assert.AreEqual(-2, _usersManager.Logare("aaa", "mama"));
        }
    }

}
