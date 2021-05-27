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
using SelectareZbor;
namespace ProiectIP_interfata
{
    public partial class DestinationPickControl : UserControl
    {
        private MySqlConnection _conn;
        private ZboruriManager _zborManager;
        private List<int> zboruri;
        public DestinationPickControl()
        {
            string MyConStr = "Server=localhost;Database=proiect_ip;uid=ruxi;pwd=password";

            _conn = new MySqlConnection(MyConStr);
            _zborManager = new ZboruriManager(_conn);
            DateTime date = DateTime.Now;
            string an = date.Year.ToString();
            string luna = date.Month.ToString();
            string zi = date.Day.ToString();

            string data_aleasa = zi + "." + luna + "." + an;
            MessageBox.Show(zi + "." + luna + "." + an);

            List<String> destinatii = _zborManager.GetDestinationBasedOnDate(data_aleasa);
            MessageBox.Show(destinatii.Count.ToString());
            InitializeComponent();
            comboBox_destination.DataSource = destinatii;

        }
        //seteaza maxSelectionCount to 1 pentru a putea alege o singura zi
        //apoi data e in selectedRange.start.ToString()
        private void monthCalendar_flightTime_DateChanged(object sender, DateRangeEventArgs e)
        {
            string data_aleasa = monthCalendar_flightTime.SelectionRange.Start.ToString();

            data_aleasa = data_aleasa.Split(' ')[0];
            string[] bucati = data_aleasa.Split('/');
            string format_data = bucati[1] + "." + bucati[0] + "." + bucati[2];
            MessageBox.Show(format_data);
            List<String> destinatii = _zborManager.GetDestinationBasedOnDate(format_data);
            comboBox_destination.DataSource = destinatii;

        }

        private void button_findFlight_Click(object sender, EventArgs e)
        {
            string data_aleasa = monthCalendar_flightTime.SelectionRange.Start.ToString();

            data_aleasa = data_aleasa.Split(' ')[0];
            string[] bucati = data_aleasa.Split('/');
            string format_data = bucati[1] + "." + bucati[0] + "." + bucati[2];
            string destinatie = comboBox_destination.SelectedValue.ToString();
            //lista ce contine id-urile cu zbourile disponibile (ar trebui sa fie afisata pe aia cu FlightPickControl)
            //trebuie cumva trimisa lista la acel panel(de ex ca parametru)
            zboruri = _zborManager.GetFlights(destinatie, format_data);
        }
        public List<int> Zboruri
        {
            get
            {
                return zboruri;
            }
        }
    }
}
