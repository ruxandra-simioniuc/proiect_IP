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
        private MySqlConnection _conn;
        private UsersManager _usersManager;
        public UserPickControl()
        {
            string MyConStr = "Server=localhost;Database=proiect_ip;uid=ruxi;pwd=password";

            _conn = new MySqlConnection(MyConStr);
            _usersManager = new UsersManager(_conn);
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string mail = textBox_login_email.Text;
            string parola = textBox_login_password.Text;
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

        private void button_signup_Click(object sender, EventArgs e)
        {
            string nume = textBox_signup_name.Text;
            string prenume = textBox_signup_surname.Text;
            string mail = textBox_signup_email.Text;
            string parola = textBox_signup_password.Text;
            string verificare_parola = textBox_signup_passwordRepeat.Text;
            if (_usersManager.signUp(nume, prenume, mail, parola, verificare_parola))
            {
                MessageBox.Show("V-ati inregistrat cu succes!");
            }
            else
            {
                MessageBox.Show("Eroare!");
            }
        }
    }
}
