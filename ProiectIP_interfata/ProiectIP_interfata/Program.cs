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
        Singleton()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        #endregion

        #region Public Methods
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
            Singleton singleton2 = Singleton.Instance();
        }
    }
}