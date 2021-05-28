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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
            UserPickControl userPickControl = new UserPickControl();
            MainControl.showControl(userPickControl, MainContent);
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

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
