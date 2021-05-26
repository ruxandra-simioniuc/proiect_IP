using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ProiectIP_interfata
{
    public partial class FlightPickControl : UserControl
    {
        public FlightPickControl()
        {
            InitializeComponent();
        }

        private void label_infoPrice_Click(object sender, EventArgs e)
        {

        }

        private void button_reservation_1_Click(object sender, EventArgs e)
        {
            SeatPickControl seatPickControl = new SeatPickControl();
            MainControl.showControl(seatPickControl, ContentFlightPick);
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            DestinationPickControl destinationPickControl = new DestinationPickControl();
            MainControl.showControl(destinationPickControl, ContentFlightPick);
        }
    }
}
