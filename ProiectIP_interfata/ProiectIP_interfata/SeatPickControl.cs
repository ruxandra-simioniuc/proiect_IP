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
    public partial class SeatPickControl : UserControl
    {
        public SeatPickControl()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            FinalDetailsControl finalDetailsControl = new FinalDetailsControl();
            MainControl.showControl(finalDetailsControl, ContentSeatPick);
        }
    }
}
