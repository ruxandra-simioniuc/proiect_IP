using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProiectIP_interfata
{
    public partial class FinalDetailsControl : UserControl
    {
        #region Private Properties
        private MySqlConnection _conn;
        #endregion

        #region Private Methods
        /// <summary>
        /// Schimba Panelul catre cel de Welcome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFinalReservation_Click(object sender, EventArgs e)
        {
            WelcomeControl welcomeControl = new WelcomeControl(_conn);
            MainControl.showControl(welcomeControl, ContentFinalDetails);
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor cu parametrii
        /// </summary>
        /// <param name="numarLocuri">locuri disponibile in avion</param>
        /// <param name="pret">pret bilet</param>
        /// <param name="destinatie">orasul destinatie</param>
        /// <param name="data">data zborului</param>
        /// <param name="conn">conexiune MySql</param>
        public FinalDetailsControl(string numarLocuri, string pret, string destinatie, string data, MySqlConnection conn)
        {
            InitializeComponent();

            labelFinalSelectedSeats.Text = numarLocuri;
            labelFinalSelectedPrice.Text = pret;
            labelFinalDestination.Text = destinatie;
            labelFinalSelectedDate.Text = data;
            _conn = conn;
        }
        #endregion        
    }
}
