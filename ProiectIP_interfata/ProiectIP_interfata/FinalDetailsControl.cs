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
        private MySqlConnection _conn;
        public FinalDetailsControl(string numarLocuri, string pret, string destinatie, string data, MySqlConnection conn)
        {
            InitializeComponent();

            label_finalSelectedSeats.Text = numarLocuri;
            label_finalSelectedPrice.Text = pret;
            label_finalDestination.Text = destinatie;
            label_finalSelectedDate.Text = data;
            _conn = conn;

        }

        private void ContentFinalDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_finalReservation_Click(object sender, EventArgs e)
        {
            WelcomeControl welcomeControl = new WelcomeControl(_conn);
            MainControl.showControl(welcomeControl, ContentFinalDetails);
        }

        private void label_finalSelectedSeats_Click(object sender, EventArgs e)
        {

        }
    }
}
