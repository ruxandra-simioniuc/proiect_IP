/**************************************************************************
 *                                                                        *
 *  File:        UnitTestGetData.cs                                       *
 *  Autor:       Teodor Colipca                                           *         
 *  Functionalitate:    Clasa pentru a testa preluarea informatiilor      *
 *    legate de destinatie din tabelul zboruri                            *
 **************************************************************************/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectareZbor;
using MySql.Data.MySqlClient;
namespace UnitTestSelectareZbor
{
    [TestClass]
    public class UnitTestGetDestinatie
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
            Assert.AreEqual("Constanta", _zboruriManager.GetDestinatie("7"));
        }
        [TestMethod]
        public void NotExistingDatabase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            ZboruriManager _zboruriManager = new ZboruriManager(_conn);
            Assert.AreEqual(null, _zboruriManager.GetDestinatie("7"));

        }
        [TestMethod]
        public void NotExistingId()
        {
            Assert.AreEqual("", _zboruriManager.GetDestinatie("900"));
        }
    }
}
