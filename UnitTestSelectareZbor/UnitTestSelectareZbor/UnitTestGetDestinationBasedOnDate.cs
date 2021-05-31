using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectareZbor;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace UnitTestSelectareZbor
{
    [TestClass]
    public class UnitTestGetDestinationBasedOnDate
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
        public void ValidTest_30_06_2021()
        {

            List<String> destinatii = new List<String>();
            destinatii.Add("Munchen");
            destinatii.Add("Paris");
            destinatii.Add("Lyon");
            destinatii.Add("Liverpool");
            destinatii.Add("Londra");
            CollectionAssert.AreEqual(destinatii, _zboruriManager.GetDestinationBasedOnDate("30.6.2021"));

        }
        [TestMethod]
        public void NotExistingDatabase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            ZboruriManager _zboruriManager = new ZboruriManager(_conn);
            Assert.AreEqual(null, _zboruriManager.GetDestinationBasedOnDate("30.6.2021"));

        }
        [TestMethod]
        public void ValidTest_20_07_2021_EmptyList()
        {

            Assert.AreEqual(0, _zboruriManager.GetDestinationBasedOnDate("20.7.2021").Count);

        }
        [TestMethod]
        public void NotExistingDate()
        {
            Assert.AreEqual(0, _zboruriManager.GetDestinationBasedOnDate("32.7.2021").Count);

        }
    }
}
