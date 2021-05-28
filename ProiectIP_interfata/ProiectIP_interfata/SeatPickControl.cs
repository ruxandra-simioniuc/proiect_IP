using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SelectareZbor;
using MySql.Data.MySqlClient;
namespace ProiectIP_interfata
{
    public partial class SeatPickControl : UserControl
    {
        private int _indexZbor;
        private int _pretZbor ;
        string seatingPlan = "";
        string[] takenSeats;
        int[] seatsByClass = { 0, 0, 0 }; // first, business, economy
        int economyClassPrice;
        int businessClassPrice;
        int firstClassPrice;
        ZboruriManager zboruriManager;
        MySqlConnection _conn;

        public SeatPickControl(int indexZbor, int pretZbor , MySqlConnection conn)
        {
            _conn = conn;
            _indexZbor = indexZbor;
            _pretZbor = pretZbor;
            InitializeComponent();

            // ReadSeatPickArgs();

            ReadSeatingPlanFromBD();

            OccupySeats();

            UpdatePriceLabels();

        }

        private void button_next_Click(object sender, EventArgs e)
        {
            zboruriManager = new ZboruriManager(_conn);
            string numarLocuri = label_selectedSeats.Text;
            string pret = label_seatPrice.Text;
            string destinatie = zboruriManager.GetDestinatie(_indexZbor.ToString());
            string data = zboruriManager.GetData(_indexZbor.ToString());



            FinalDetailsControl finalDetailsControl = new FinalDetailsControl(numarLocuri, pret, destinatie, data, _conn);
            MainControl.showControl(finalDetailsControl, ContentSeatPick);
        }

        private void SelectFirstClass(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Split('_')[1];

            if (btn.BackColor == Color.DarkRed)
            {
                btn.BackColor = Color.Turquoise;

                seatsByClass[0]--;

                seatingPlan = seatingPlan.Replace(" " + btnName, "");

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();

                //MessageBox.Show(seatingPlan);
            }
            else
            {
                btn.BackColor = Color.DarkRed;

                seatsByClass[0]++;

                seatingPlan += " " + btnName;

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();

                //MessageBox.Show(seatingPlan);
            }

        }

        private void SelectBusinessClass(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Split('_')[1];

            if (btn.BackColor == Color.DarkRed)
            {
                btn.BackColor = Color.SteelBlue;

                seatsByClass[1]--;

                seatingPlan = seatingPlan.Replace(" " + btnName, "");

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();

                //MessageBox.Show(seatingPlan);
            }
            else
            {
                btn.BackColor = Color.DarkRed;

                seatsByClass[1]++; // poate un check

                seatingPlan += " " + btnName;

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();

                //MessageBox.Show(seatingPlan);
            }
        }

        private void SelectEconomyClass(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Name.Split('_')[1];

            if (btn.BackColor == Color.DarkRed)
            {
                btn.BackColor = Color.Orange;

                seatsByClass[2]--;

                seatingPlan = seatingPlan.Replace(" " + btnName, "");

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();

                //MessageBox.Show(seatingPlan);
            }
            else
            {
                btn.BackColor = Color.DarkRed;

                seatsByClass[2]++;

                seatingPlan += " " + btnName;

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();

                //MessageBox.Show(seatingPlan);
            }
        }

        private void OccupySeats()
        {
            takenSeats = seatingPlan.Split(' ');

            for (int i = 1; i < takenSeats.Length; i++)
            {
               
                try
                {
                    if (takenSeats[i].Length > 1) {
                        Button btn = (Button)ContentSeatPick.Controls["button_" + takenSeats[i]];

                        btn.BackColor = Color.DarkSlateGray;
                        btn.Enabled = false;
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            UpdateSeatingLabels();
        }

        private void WriteSeatingPlanToBD(string flightIndex)
        {
            string fileName = @"..\..\Resources\takenSeats.txt";

            var lines = System.IO.File.ReadAllLines(fileName);
            int count = Convert.ToInt32(flightIndex) - 1;
            lines[count] = seatingPlan;

            File.WriteAllLines(fileName, lines);
        }

        private void ReadSeatingPlanFromBD()
        {
            string fileName = @"..\..\Resources\takenSeats.txt";

            var lines = System.IO.File.ReadAllLines(fileName);
            int count = _indexZbor - 1;
            seatingPlan = lines[count];

            //MessageBox.Show(seatingPlan);
            //File.WriteAllLines(fileName, lines);
        }

        private void ReadSeatPickArgs()
        {
            string fileName = @"..\..\Resources\SeatPickArgs.txt";

            string lines = File.ReadAllText(fileName);

            _indexZbor = Convert.ToInt32(lines.Split(' ')[0]);

            _pretZbor = Convert.ToInt32(lines.Split(' ')[1]);

            //MessageBox.Show(_indexZbor.ToString());


            //MessageBox.Show(_pretZbor.ToString());
        }

        private void UpdatePriceLabels()
        {
            economyClassPrice = _pretZbor;
            businessClassPrice = _pretZbor + _pretZbor / 5;
            firstClassPrice = _pretZbor + _pretZbor / 2;

            labelFirstClass.Text = firstClassPrice.ToString();
            labelBusinessClass.Text = businessClassPrice.ToString();
            labelEconomyClass.Text = economyClassPrice.ToString();
        }

        private void UpdateSeatingLabels()
        {
            int nrOfSeats = seatsByClass[0] + seatsByClass[1] + seatsByClass[2];
            int totalPrice = 0;

            label_selectedSeats.Text = nrOfSeats.ToString();

            totalPrice = seatsByClass[0] * firstClassPrice + seatsByClass[1] * businessClassPrice + seatsByClass[2] * economyClassPrice;

            label_seatPrice.Text = totalPrice.ToString();
        }

        private void ContentSeatPick_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ReadSeatPickArgs();

            ReadSeatingPlanFromBD();

            OccupySeats();

            UpdatePriceLabels();
        }

        private void label_selectedSeats_Click(object sender, EventArgs e)
        {

        }
    }
}
