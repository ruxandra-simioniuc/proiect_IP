/**************************************************************************
 *                                                                        *
 *  File:        WelcomeControl.cs                                        *
 *  Autor:       Ruxandra Simioniuc                                       *         
 *  Functionalitate:    Panel care apare cand un utilizator se autentifica*
 **************************************************************************/

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
    public partial class WelcomeControl : UserControl
    {
        #region Private Member Variables
        private MySqlConnection _conn;
        #endregion

        #region Private Methods
        /// <summary>
        /// Schimba Panelul la cel de alegere destinatie bilet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            DestinationPickControl destinationPickControl = new DestinationPickControl(_conn);
            MainControl.showControl(destinationPickControl, WelcomeContent);
        }

        /// <summary>
        /// Schimba Panelul la cel de logare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            UserPickControl userPickControl = new UserPickControl();
            MainControl.showControl(userPickControl, WelcomeContent);
        }
        #endregion

        #region Contructors
        public WelcomeControl(MySqlConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }
        #endregion        
    }
}
