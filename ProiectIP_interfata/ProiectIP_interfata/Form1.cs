using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogIn;
using MySql.Data.MySqlClient;
namespace ProiectIP_interfata
{
    public partial class Form1 : Form
    {
        private MySqlConnection _conn;
        private UsersManager _usersManager;
        public Form1()
        {
            string MyConStr = "Server=localhost;Database=proiect_ip;uid=teodor;pwd=Dismas67!";

            _conn = new MySqlConnection(MyConStr);
            _usersManager = new UsersManager(_conn);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string mail = textBox_login_email.Text;
            string parola = textBox_login_password.Text;
            int id = _usersManager.Logare(mail, parola);
            if(id==-1)
            {
                MessageBox.Show("Date invalide");
            }
            else {
                DestinationPickControl flightPicker = new DestinationPickControl();
                showControl(flightPicker);
            }

        }

        public void showControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);

        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            string nume = textBox_signup_name.Text;
            string prenume = textBox_signup_surname.Text;
            string mail = textBox_signup_email.Text;
            string parola = textBox_signup_password.Text;
            string verificare_parola = textBox_signup_repeat_password.Text;
            if(_usersManager.signUp(nume,prenume,mail,parola,verificare_parola))
            {
                MessageBox.Show("V-ati inregistrat cu succes!");
            }
            else
            {
                MessageBox.Show("Parolele nu corespund!");
            }
        }
    }
}
