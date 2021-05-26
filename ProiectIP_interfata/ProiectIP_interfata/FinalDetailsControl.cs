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
            Form1 begin = new Form1();
            MainControl.showControl(begin.Content, ContentFinalDetails);
        }
    }
}
