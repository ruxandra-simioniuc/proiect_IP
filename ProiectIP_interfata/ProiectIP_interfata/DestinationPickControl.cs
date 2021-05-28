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
        #region Private Member Variables
        private MySqlConnection _conn;
        private ZboruriManager _zborManager;
        private List<int> _zboruri;
        #endregion

        #region Private Methods
        /// <summary>
        /// seteaza maxSelectionCount to 1 pentru a putea alege o singura zi, apoi data e in selectedRange.start.ToString()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void monthCalendarFlightTime_DateChanged(object sender, DateRangeEventArgs e)
        {
            string data_aleasa = monthCalendarFlightTime.SelectionRange.Start.ToString();

            data_aleasa = data_aleasa.Split(' ')[0];
            string[] bucati = data_aleasa.Split('/');
            string format_data = bucati[1] + "." + bucati[0] + "." + bucati[2];
            //MessageBox.Show(format_data);
            List<String> destinatii = _zborManager.GetDestinationBasedOnDate(format_data);
            comboBoxDestination.DataSource = destinatii;

        }

        /// <summary>
        /// Schimba Panelul, trimite conexiunea pt baza de data si zborurile disponibile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindFlight_Click(object sender, EventArgs e)
        {
            try
            {
                string dataAleasa = monthCalendarFlightTime.SelectionRange.Start.ToString();

                dataAleasa = dataAleasa.Split(' ')[0];
                string[] bucati = dataAleasa.Split('/');
                string formatData = bucati[1] + "." + bucati[0] + "." + bucati[2];
                string destinatie = comboBoxDestination.SelectedValue.ToString();

                _zboruri = _zborManager.GetFlights(destinatie, formatData);
                FlightPickControl flightPickControl = new FlightPickControl(_conn, _zboruri);
                MainControl.showControl(flightPickControl, ContentDestinationPick);
            }
            catch (Exception)
            {
                MessageBox.Show("Trebuie selectată o destinație validă!");
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="conn"></param>
        public DestinationPickControl(MySqlConnection conn)
        {
            string an, luna, zi, dataAleasa;
            List<string> destinatii;

            _conn = conn;
            _zborManager = new ZboruriManager(_conn);
            DateTime date = DateTime.Now;
            an = date.Year.ToString();
            luna = date.Month.ToString();
            zi = date.Day.ToString();

            dataAleasa = zi + "." + luna + "." + an;
            
            destinatii = _zborManager.GetDestinationBasedOnDate(dataAleasa);

            InitializeComponent();
            comboBoxDestination.DataSource = destinatii;

        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Getter pentru zborurile disponibile
        /// </summary>
        public List<int> Zboruri
        {
            get
            {
                return _zboruri;
            }
        }
        #endregion
    }
}
