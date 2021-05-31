/**************************************************************************
 *                                                                        *
 *  File:        UnitTestGetData.cs                                       *
 *  Autor:       Teodor Colipca                                           *         
 *  Functionalitate:    Clasa pentru a testa preluarea informatiilor      *
 *    legate de fiecare zbor din tabelul zboruri                          *
 **************************************************************************/


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SelectareZbor;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace UnitTestSelectareZbor
{
    [TestClass]
    public class UnitTestGetFlights
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
        public void ValidTest_Munchen_30_06_2021()
        {
            List<int> iduri = new List<int>();
            iduri.Add(102);
            iduri.Add(103);
            iduri.Add(104);
            CollectionAssert.AreEqual(iduri, _zboruriManager.GetFlights("Munchen","30.6.2021"));
        }
        [TestMethod]
        public void NotExistingDatabase()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=teodo;pwd=Dismas67!";
            MySqlConnection _conn = new MySqlConnection(myConStr);
            ZboruriManager _zboruriManager = new ZboruriManager(_conn);
            CollectionAssert.AreEqual(null, _zboruriManager.GetFlights("Munchen", "30.6.2021"));

        }
        [TestMethod]
        public void NotExistingDestination()
        {

            Assert.AreEqual(0, _zboruriManager.GetFlights("Mama", "30.6.2021").Count);
        }
        [TestMethod]
        public void NotExistingDate()
        {

            Assert.AreEqual(0, _zboruriManager.GetFlights("Munchen", "32.6.2021").Count);
        }
        [TestMethod]
        public void NotExistingDateAndDestination()
        {

            Assert.AreEqual(0, _zboruriManager.GetFlights("Mama", "32.6.2021").Count);
        }

    }
}
