/**************************************************************************
 *                                                                        *
 *  File:        Form_RezervareBilete.cs                                  *
 *  Autor:       Ruxandra Simioniuc                                       *         
 *  Functionalitate:    Formularul principal, template-ul unde se afiseaza*
 *  pe rand toate panel-urile; contine butoane de Help, Despre, Iesire    *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LogIn;
namespace ProiectIP_interfata
{

    public partial class Form_RezervareBilete : Form
    {
        #region Constructors
        /// <summary>
        /// Incarca layout-ul de login in template-ul formularului
        /// </summary>
        public Form_RezervareBilete()
        {
            
            InitializeComponent();

            UserPickControl userPickControl = new UserPickControl();
            MainControl.showControl(userPickControl, MainContent);
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Inchide aplicatia la apasarea butonului "Iesire"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Afiseaza documentatia .chm (help) la apasarea butonului Help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"../../Resources/Rezervare bilete avion.chm");
        }


        #endregion

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect IP 2021. Rezervarea biletelor de zbor cu plecarea din Iasi");
        }
    }
}
