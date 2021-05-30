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

            try
            {
                if (id == -1)
                {
                    textBoxLoginEmail.Text = "";
                    textBoxLoginPassword.Text = "";
                    MessageBox.Show("Date invalide");
                }
                else if(id == -2)
                {
                    textBoxLoginEmail.Text = "";
                    textBoxLoginPassword.Text = "";
                    MessageBox.Show("Eroare. Nu s-a putut realiza conexiunea la baza de date.");
                }
                else
                {
                    WelcomeControl welcomeControl = new WelcomeControl(_conn);
                    MainControl.showControl(welcomeControl, UserPickContent);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            string verificareParola = textBoxSignUpPasswordRepeat.Text;

           
            if (_usersManager.signUp(nume, prenume, mail, parola, verificareParola) == 1)
            {
                MessageBox.Show("V-ati inregistrat cu succes!");
                textBoxSignUpEmail.Text = "";
                textBoxSignUpName.Text = "";
                textBoxSignUpPassword.Text = "";
                textBoxSignUpPasswordRepeat.Text = "";
                textBoxSignUpSurname.Text = "";

            }
            else if (_usersManager.signUp(nume, prenume, mail, parola, verificareParola) == -1)
            {
                textBoxSignUpEmail.Text = "";
                textBoxSignUpName.Text = "";
                textBoxSignUpPassword.Text = "";
                textBoxSignUpPasswordRepeat.Text = "";
                textBoxSignUpSurname.Text = "";
                MessageBox.Show("Date invalide!");
            }
            else if (_usersManager.signUp(nume, prenume, mail, parola, verificareParola) == -2)
            {

                MessageBox.Show("Eroare. Nu s-a putut realiza conexiunea la baza de date.");
            }
            else
            {
                textBoxSignUpEmail.Text = "";
                textBoxSignUpName.Text = "";
                textBoxSignUpPassword.Text = "";
                textBoxSignUpPasswordRepeat.Text = "";
                textBoxSignUpSurname.Text = "";
                MessageBox.Show("Exista deja un utilizator cu acest mail");

            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor care face conexiunea MySQL cu baza de date
        /// </summary>
        public UserPickControl()
        {

            string myConStr;
            try
            {
                myConStr = "Server=localhost;Database=proiect_ip;uid=matei;pwd=pass";
                _conn = new MySqlConnection(myConStr);
                _usersManager = new UsersManager(_conn);
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        #endregion
    }
}
