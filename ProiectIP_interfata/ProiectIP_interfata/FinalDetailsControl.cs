using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP_interfata
{
    public partial class FinalDetailsControl : UserControl
    {
        public FinalDetailsControl()
        {
            InitializeComponent();
        }

        private void ContentFinalDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_finalReservation_Click(object sender, EventArgs e)
        {
            UserPickControl userPickControl = new UserPickControl();
            MainControl.showControl(userPickControl, ContentFinalDetails);
        }

        private void label_finalSelectedSeats_Click(object sender, EventArgs e)
        {

        }
    }
}
