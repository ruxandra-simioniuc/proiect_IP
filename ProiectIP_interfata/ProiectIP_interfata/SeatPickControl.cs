/**************************************************************************
 *                                                                        *
 *  File:        SeatPickControl.cs                                       *
 *  Autor:       Necula Claudiu                                           *         
 *  Functionalitate:    Panel unde se incarca locurile ocupate si se pot  *
 *  selecta locuri neocupate                                              *
 **************************************************************************/

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
        #region Private Member Variables
        private int _indexZbor;
        private int _pretZbor ;
        private string seatingPlan = "";
        private string[] takenSeats;
        private int[] seatsByClass = { 0, 0, 0 }; // first, business, economy
        private int economyClassPrice;
        private int businessClassPrice;
        private int firstClassPrice;
        private ZboruriManager zboruriManager;
        private MySqlConnection _conn;
        #endregion

        #region Private Methods
        /// <summary>
        /// Schimba Panelul in cel de Checkout si trimite parametrii mai departe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            zboruriManager = new ZboruriManager(_conn);
            string numarLocuri = labelSelectedSeats.Text;
            string pret = labelSeatPrice.Text;
            string destinatie = zboruriManager.GetDestinatie(_indexZbor.ToString());
            string data = zboruriManager.GetData(_indexZbor.ToString());

            FinalDetailsControl finalDetailsControl = new FinalDetailsControl(numarLocuri, pret, destinatie, data, _conn);
            MainControl.showControl(finalDetailsControl, ContentSeatPick);
        }

        /// <summary>
        /// Callback pt butoanele First Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            }
            else
            {
                btn.BackColor = Color.DarkRed;

                seatsByClass[0]++;

                seatingPlan += " " + btnName;

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();
            }

        }

        /// <summary>
        /// Callback pt butoanele Business Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            }
            else
            {
                btn.BackColor = Color.DarkRed;

                seatsByClass[1]++;

                seatingPlan += " " + btnName;

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();
            }
        }

        /// <summary>
        /// Callback pentru butoanele Economy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            }
            else
            {
                btn.BackColor = Color.DarkRed;

                seatsByClass[2]++;

                seatingPlan += " " + btnName;

                WriteSeatingPlanToBD(seatingPlan.Split(' ')[0]);

                UpdateSeatingLabels();
            }
        }

        /// <summary>
        /// Marcheaza locurile indisponibile ca fiind ocupate
        /// </summary>
        private void OccupySeats()
        {
            takenSeats = seatingPlan.Split(' ');

            for (int i = 1; i < takenSeats.Length; i++)
            {

                try
                {
                    if (takenSeats[i].Length > 1)
                    {
                        Button btn = (Button)ContentSeatPick.Controls["button_" + takenSeats[i]];

                        btn.BackColor = Color.DarkSlateGray;
                        btn.Enabled = false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            UpdateSeatingLabels();
        }

        /// <summary>
        /// Scrie locurile ocupate in fisier
        /// </summary>
        /// <param name="flightIndex"></param>
        private void WriteSeatingPlanToBD(string flightIndex)
        {
            string fileName = @"..\..\Resources\takenSeats.txt";

            var lines = System.IO.File.ReadAllLines(fileName);
            int count = Convert.ToInt32(flightIndex) - 1;
            lines[count] = seatingPlan;

            File.WriteAllLines(fileName, lines);
        }

        /// <summary>
        /// Citeste locurile ocupate din fisier
        /// </summary>
        private void ReadSeatingPlanFromBD()
        {
            string fileName = @"..\..\Resources\takenSeats.txt";

            var lines = System.IO.File.ReadAllLines(fileName);
            int count = _indexZbor - 1;
            seatingPlan = lines[count];
        }

        /// <summary>
        /// Actualizeaza Labelurile pentru preturi
        /// </summary>
        private void UpdatePriceLabels()
        {
            economyClassPrice = _pretZbor;
            businessClassPrice = _pretZbor + _pretZbor / 5;
            firstClassPrice = _pretZbor + _pretZbor / 2;

            labelFirstClass.Text = firstClassPrice.ToString();
            labelBusinessClass.Text = businessClassPrice.ToString();
            labelEconomyClass.Text = economyClassPrice.ToString();
        }

        /// <summary>
        /// Actualizeaza Labelurile pentru nr de locuri selectate si pretul total al biletelor selectate
        /// </summary>
        private void UpdateSeatingLabels()
        {
            int nrOfSeats = seatsByClass[0] + seatsByClass[1] + seatsByClass[2];
            int totalPrice = 0;

            labelSelectedSeats.Text = nrOfSeats.ToString();

            totalPrice = seatsByClass[0] * firstClassPrice + seatsByClass[1] * businessClassPrice + seatsByClass[2] * economyClassPrice;

            labelSeatPrice.Text = totalPrice.ToString() + " €";
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor parametrizat
        /// </summary>
        /// <param name="indexZbor">ID ul zborului</param>
        /// <param name="pretZbor">pretul biletului</param>
        /// <param name="conn">conexiune MySQL</param>
        public SeatPickControl(int indexZbor, int pretZbor , MySqlConnection conn)
        {
            _conn = conn;
            _indexZbor = indexZbor;
            _pretZbor = pretZbor;

            InitializeComponent();

            ReadSeatingPlanFromBD();

            OccupySeats();

            UpdatePriceLabels();
        }
        #endregion
    }
}
