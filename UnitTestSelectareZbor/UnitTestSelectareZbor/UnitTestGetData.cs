using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectareZbor;
using MySql.Data.MySqlClient;
namespace UnitTestSelectareZbor
{
    [TestClass]
    public class UnitTestGetData
    {
        private ZboruriManager _zboruriManager;
        [TestInitialize]
        public void Init()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodor;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            _zboruriManager = new ZboruriManager(_conn);
        }
        [TestMethod]
        public void ValidTestId7()
        {
            Assert.AreEqual("25.6.2021", _zboruriManager.GetData("7"));
        }
        [TestMethod]
        public void NotExistingDatabase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            ZboruriManager _zboruriManager = new ZboruriManager(_conn);
            Assert.AreEqual(null, _zboruriManager.GetData("7"));

        }
        [TestMethod]
        public void NotExistingId()
        {
            Assert.AreEqual("", _zboruriManager.GetData("900"));
        }
    }
}
