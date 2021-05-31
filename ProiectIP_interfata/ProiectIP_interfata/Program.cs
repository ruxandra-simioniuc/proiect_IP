﻿/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Autor:       Matei Chiteala                                           *         
 *  Functionalitate:    Programul principal, implementat cu modelul de    *
 *  proiectare Singleton                                                  *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP_interfata
{
    public sealed class Singleton
    {
        #region Private Member Variables
        private static readonly object _lock = new object();
        private static Singleton instance = null;
        #endregion

        #region Constructors
        /// <summary>
        /// constructor privat ce instantiaza obiectul
        /// </summary>
        private Singleton()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                MessageBox.Show("Deja exista interfata pornita!");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_RezervareBilete());

            GC.KeepAlive(mutex);
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// metoda ce returneaza o noua instanta sau instanta curenta daca exista deja una
        /// </summary>
        /// <returns></returns>
        internal static Singleton Instance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
        #endregion
    }
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Singleton singleton = Singleton.Instance();

        }
    }
}