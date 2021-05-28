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
using LogIn;

namespace ProiectIP_interfata
{
    public partial class UserPickControl : UserControl
    {
        #region Private Member Variables
        private MySqlConnection _conn;
        private UsersManager _usersManager;
        #endregion

        #region Private Methods
        /// <summary>
        /// Verifica logarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string mail = textBoxLoginEmail.Text;
            string parola = textBoxLoginPassword.Text;
            int id = _usersManager.Logare(mail, parola);

            if (id == -1)
            {
                MessageBox.Show("Date invalide");
            }
            else
            {
                WelcomeControl welcomeControl = new WelcomeControl(_conn);
                MainControl.showControl(welcomeControl, UserPickContent);
            }
        }

        /// <summary>
        /// Incearca sa faca sign up pt un utilizator nou
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            string nume = textBoxSignUpName.Text;
            string prenume = textBoxSignUpSurname.Text;
            string mail = textBoxSignUpEmail.Text;
            string parola = textBoxSignUpPassword.Text;
            string verificareParola = textBoSignUpPasswordRepeat.Text;

            if (_usersManager.signUp(nume, prenume, mail, parola, verificareParola))
            {
                MessageBox.Show("V-ati inregistrat cu succes!");
            }
            else
            {
                MessageBox.Show("Eroare!");
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor care face conexiunea MySQL cu baza de date
        /// </summary>
        public UserPickControl()
        {
            string myConStr = "Server=localhost;Database=proiect_ip;uid=claudiu;pwd=pass_1234";

            _conn = new MySqlConnection(myConStr);
            _usersManager = new UsersManager(_conn);
            InitializeComponent();
        }
        #endregion
    }
}
