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
using MySql.Data.MySqlClient;
using SelectareZbor;
using System.IO;

namespace ProiectIP_interfata
{

    public partial class FlightPickControl : UserControl
    {
        private MySqlConnection _conn;
        private ZboruriManager _zborManager;
        private List<int> _zboruri;
        private Panel[] _panels;
        private Button[] _buttons;
        private List<FlightControls> _fc;
        private List<Info_Zbor> _informatii;
        public struct FlightControls
        {
            Label origin;
            Label destination;
            Label departure_time;
            Label arrival_time;
            Label duration;
            Label price;

            public FlightControls(Label _origin,
            Label _destination,
            Label _departure_time,
            Label _arrival_time,
            Label _duration,
            Label _price)
            {
                origin = _origin;
                destination = _destination;
                departure_time = _departure_time;
                arrival_time = _arrival_time;
                duration = _duration;
                price = _price;

            }
            public int GetPret
            {
                get
                {
                    string simple_price = price.Text.Replace("€", "");
                    return Convert.ToInt32(simple_price);
                }
            }

            public void assignText(string _origin, string _destination, string _departure, string _arrival, string _duration, string _price)
            {
                origin.Text = _origin;
                destination.Text = _destination;
                departure_time.Text = _departure;
                arrival_time.Text = _arrival;
                string[] aux = _duration.Split(':');
                if(int.Parse(aux[1]) < 10)
                {
                    aux[1] = "0" + aux[1];
                    _duration = aux[0] + ":" + aux[1];
                }

                duration.Text = _duration + " h";
                price.Text = _price + "€";
            }
        }
        public FlightPickControl(MySqlConnection conn, List<int> zboruri)
        {
            InitializeComponent();
            Label[] _origin = { label_Origin_1, label_Origin_2, label_Origin_3, label_Origin_4 };
            Label[] _destination = { label_Destination_1, label_Destination_2, label_Destination_3, label_Destination_4 };
            Label[] _departure = { label_departureTime_1, label_departureTime_2, label_departureTime_3, label_departureTime_4 };
            Label[] _arrival = { label_arrivalTime_1, label_arrivalTime_2, label_arrivalTime_3, label_arrivalTime_4 };
            Label[] _duration = { label_duration_1, label_duration_2, label_duration_3, label_duration_4 };
            Label[] _price = { label_Price_1, label_Price_2, label_Price_3, label_Price_4 };
            _conn = conn;
            _zboruri = zboruri;
            _zborManager = new ZboruriManager(conn);
            
            MessageBox.Show(_zboruri.Count.ToString());
            _panels = new Panel[] { panel1, panel3, panel5, panel7 };
            _buttons = new Button[] { button_reservation_1, button_reservation_2, button_reservation_3, button_reservation_4 };
            _fc = new List<FlightControls>();
            _informatii = _zborManager.GetInfo(_zboruri);
            for (int i = 0; i < _panels.Length - _zboruri.Count; ++i)
            {
                _panels[_panels.Length - i-1].Hide();
               

            }
            for(int i=0;i<_zboruri.Count;++i)
            {
                FlightControls tempFC = new FlightControls(_origin[i], _destination[i], _departure[i], _arrival[i], _duration[i], _price[i]);
                _fc.Add(tempFC);
                _fc[i].assignText(_informatii[i].getOrasPlecare, _informatii[i].getOrasSosire,
                    _informatii[i].getOraPlecare, _informatii[i].getOraSosire, _informatii[i].getInterval, _informatii[i].getPret.ToString());
            }
        }
        private void label_infoPrice_Click(object sender, EventArgs e)
        {

        }

        private void button_reservation_1_Click(object sender, EventArgs e)
        {
            int indexZbor = 0;
            int pretZbor = 0;

            for (int i=0;i<_buttons.Length;++i)
            {
                if(sender==_buttons[i])
                {
                    indexZbor = _zboruri[i];
                    pretZbor = _fc[i].GetPret;
                    MessageBox.Show(indexZbor.ToString());

                    MessageBox.Show(pretZbor.ToString());
                }
            }

            //trebuie sa vad al catelea buton din _buttons[] a fost apasat=> index i
            //_zboruri[i] voi avea id_zbor al zborului ales!!
            //=> deschid fisierul ala unde am toate locurile ocupate pt fiecare zbor
           // WriteToFileSeatsArgs(indexZbor, pretZbor);

            SeatPickControl seatPickControl = new SeatPickControl(indexZbor, pretZbor, _conn);
            MainControl.showControl(seatPickControl, ContentFlightPick);
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            DestinationPickControl destinationPickControl = new DestinationPickControl(_conn);
            MainControl.showControl(destinationPickControl, ContentFlightPick);
        }

        private void label_Price_1_Click(object sender, EventArgs e)
        {

        }

        private void WriteToFileSeatsArgs(int indexZbor, int pretZbor)
        {
            string someText = indexZbor.ToString() + " " + pretZbor.ToString();
            string filePath = @"..\..\Resources\SeatPickArgs.txt";

            File.WriteAllText(filePath, someText);

            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);
        }
    }
}
