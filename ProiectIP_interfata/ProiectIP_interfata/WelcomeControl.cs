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
        private MySqlConnection _conn;
        public WelcomeControl(MySqlConnection conn)
        {
            InitializeComponent();
            _conn = conn;
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            DestinationPickControl destinationPickControl = new DestinationPickControl(_conn);
            MainControl.showControl(destinationPickControl, WelcomeContent);
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            UserPickControl userPickControl = new UserPickControl();
            MainControl.showControl(userPickControl, WelcomeContent);
        }
    }
}
