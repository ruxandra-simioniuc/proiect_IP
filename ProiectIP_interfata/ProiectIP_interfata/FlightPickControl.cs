/**************************************************************************
 *                                                                        *
 *  File:        FlightPickControl.cs                                     *
 *  Autor:       Necula Claudiu                                           *         
 *  Functionalitate:    Panel unde se incarca zborurile disponibile si se *
 *  poate selecta zborul dorit                                            *
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
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using SelectareZbor;
using System.IO;

namespace ProiectIP_interfata
{
    public partial class FlightPickControl : UserControl
    {
        #region Private Member Variables
        private MySqlConnection _conn;
        private ZboruriManager _zborManager;
        private List<int> _zboruri;
        private Panel[] _panels;
        private Button[] _buttons;
        private List<FlightControls> _fc;
        private List<Info_Zbor> _informatii;
        #endregion

        #region Private Methods
        /// <summary>
        /// Schimba Panelul catre alegere loc si trimite parametrii: id zbor si pret zbor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            int indexZbor = 0;
            int pretZbor = 0;

            for (int i = 0; i < _buttons.Length; ++i)
            {
                if (sender == _buttons[i])
                {
                    indexZbor = _zboruri[i];
                    pretZbor = _fc[i].GetPret;
                }
            }

            SeatPickControl seatPickControl = new SeatPickControl(indexZbor, pretZbor, _conn);
            MainControl.showControl(seatPickControl, ContentFlightPick);
        }

        /// <summary>
        /// Schimba Panelul catre alegere destinatie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            DestinationPickControl destinationPickControl = new DestinationPickControl(_conn);
            MainControl.showControl(destinationPickControl, ContentFlightPick);
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor cu parametrii conexiune MySQL si zboruri disponibile
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="zboruri"></param>
        public FlightPickControl(MySqlConnection conn, List<int> zboruri)
        {
            InitializeComponent();
            Label[] _origin = { labelOrigin_1, labelOrigin_2, labelOrigin_3, labelOrigin_4 };
            Label[] _destination = { labelDestination_1, labelDestination_2, labelDestination_3, labelDestination_4 };
            Label[] _departure = { labelDepartureTime_1, labelDepartureTime_2, labelDepartureTime_3, labelDepartureTime_4 };
            Label[] _arrival = { label_arrivalTime_1, label_arrivalTime_2, label_arrivalTime_3, label_arrivalTime_4 };
            Label[] _duration = { labelDuration_1, labelDuration_2, labelDuration_3, labelDuration_4 };
            Label[] _price = { labelPrice_1, labelPrice_2, labelPrice_3, labelPrice_4 };

            _conn = conn;
            _zboruri = zboruri;
            _zborManager = new ZboruriManager(conn);
            
            _panels = new Panel[] { panel1, panel3, panel5, panel7 };
            _buttons = new Button[] { buttonReservation_1, buttonReservation_2, buttonReservation_3, buttonReservation_4 };
            _fc = new List<FlightControls>();
            _informatii = _zborManager.GetInfo(_zboruri);

            for (int i = 0; i < _panels.Length - _zboruri.Count; ++i)
            {
                _panels[_panels.Length - i-1].Hide();              
            }

            for(int i=0; i<_zboruri.Count;++i)
            {
                FlightControls tempFC = new FlightControls(_origin[i], _destination[i], _departure[i], _arrival[i], _duration[i], _price[i]);
                _fc.Add(tempFC);
                _fc[i].assignText(_informatii[i].getOrasPlecare, _informatii[i].getOrasSosire,
                    _informatii[i].getOraPlecare, _informatii[i].getOraSosire, _informatii[i].getInterval, _informatii[i].getPret.ToString());
            }
        }
        #endregion

        #region Public Struct
        public struct FlightControls
        {
            #region Private Member Variables
            Label origin;
            Label destination;
            Label departureTime;
            Label arrivalTime;
            Label duration;
            Label price;
            #endregion

            #region Constructor
            /// <summary>
            /// Constructor cu parametrii labeluri
            /// </summary>
            /// <param name="_origin"></param>
            /// <param name="_destination"></param>
            /// <param name="_departureTime"></param>
            /// <param name="_arrivalTime"></param>
            /// <param name="_duration"></param>
            /// <param name="_price"></param>
            public FlightControls(Label _origin,
            Label _destination,
            Label _departureTime,
            Label _arrivalTime,
            Label _duration,
            Label _price)
            {
                origin = _origin;
                destination = _destination;
                departureTime = _departureTime;
                arrivalTime = _arrivalTime;
                duration = _duration;
                price = _price;
            }
            #endregion

            #region Public Methods
            /// <summary>
            /// Adauga text pentru labelurile existente
            /// </summary>
            /// <param name="_origin"></param>
            /// <param name="_destination"></param>
            /// <param name="_departure"></param>
            /// <param name="_arrival"></param>
            /// <param name="_duration"></param>
            /// <param name="_price"></param>
            public void assignText(string _origin, string _destination, string _departure, string _arrival, string _duration, string _price)
            {
                origin.Text = _origin;
                destination.Text = _destination;
                departureTime.Text = _departure;
                arrivalTime.Text = _arrival;
                string[] aux = _duration.Split(':');
                if (int.Parse(aux[1]) < 10)
                {
                    aux[1] = "0" + aux[1];
                    _duration = aux[0] + ":" + aux[1];
                }

                duration.Text = _duration + " h";
                price.Text = _price + "€";
            }
            #endregion

            #region Public Properties
            /// <summary>
            /// Getter pt pret
            /// </summary>
            public int GetPret
            {
                get
                {
                    string simplePrice = price.Text.Replace("€", "");
                    return Convert.ToInt32(simplePrice);
                }
            }
            #endregion

        }
        #endregion
    }
}
