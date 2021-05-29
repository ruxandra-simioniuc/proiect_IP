using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SelectareZbor
{
    /// <summary>
    /// Clasa ce organizeaza alegerea datei, a destinatiei si a zborurilor
    /// </summary>
    public class ZboruriManager
    {
        #region Private Member Variables
        /// <summary>
        /// variabila ce retine conexiunea
        /// </summary>
        private MySqlConnection _conn;
        #endregion
        #region Constructors
        /// <summary>
        /// Constructorul clasei ce primeste ca parametru conexiunea la baza de date
        /// </summary>
        /// <param name="conn"></param>
        public ZboruriManager(MySqlConnection conn)
        {
            _conn = conn;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// returneaza toate destinatiile posibile din data trimisa ca parametru
        /// </summary>
        /// <param name="Date"></param>
        /// <returns></returns>
        public List<String> GetDestinationBasedOnDate(string Date)
        {
            try
            {
                _conn.Open();
                List<String> destinatii = new List<String>();
                string sql = "SELECT DISTINCT destinatie from zboruri where data_zbor=@data;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@data", Date);
                cmd.Prepare();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    destinatii.Add(rdr.GetString(0));
                }

                cmd.Dispose();
                _conn.Close();
                return destinatii;
            }
            catch (Exception)
            {
                return null;
            }



        }
        /// <summary>
        /// returneaza toate zborurile in functie de data si destinatia aleasa
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="Date"></param>
        /// <returns></returns>
        public List<int> GetFlights(string destination, string Date)
        {
            try
            {
                _conn.Open();
                List<int> flights = new List<int>();
                string sql = "SELECT id_zbor from zboruri where data_zbor=@data and destinatie=@destinatie;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@data", Date);
                cmd.Parameters.AddWithValue("@destinatie", destination);
                cmd.Prepare();
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    flights.Add(rdr.GetInt32(0));
                }
                cmd.Dispose();
                _conn.Close();
                return flights;
            }
            catch (Exception)
            {
                return null;
            }

        }
        /// <summary>
        /// returneaza data zborului ales
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetData(string id)
        {
            try
            {
                _conn.Open();
                string sql = "SELECT data_zbor from zboruri where id_zbor=@id;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader rdr = cmd.ExecuteReader();
                string data = "";
                if (rdr.Read())
                    data = rdr.GetString(0);
                cmd.Dispose();
                _conn.Close();
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// returneaza destinatia zborului ales
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetDestinatie(string id)
        {
            try
            {
                _conn.Open();
                string sql = "SELECT destinatie from zboruri where id_zbor=@id;";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();
                MySqlDataReader rdr = cmd.ExecuteReader();
                string destinatie = "";
                if (rdr.Read())
                    destinatie = rdr.GetString(0);
                cmd.Dispose();
                _conn.Close();
                return destinatie;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// returneaza toate informatiile zborurilor pe baza id-urilor trimise
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Info_Zbor> GetInfo(List<int> id)
        {
            try
            {
                List<Info_Zbor> informatii = new List<Info_Zbor>();
                for (int i = 0; i < id.Count; ++i)
                {
                    _conn.Open();
                    string sql = "SELECT ora_plecarii, ora_sosirii, pret, destinatie  from zboruri where id_zbor=@id;";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = _conn;
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", id[i]);
                    cmd.Prepare();
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        informatii.Add(new Info_Zbor(rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2), "Iasi", rdr.GetString(3)));
                    }
                    cmd.Dispose();
                    _conn.Close();

                }
                return informatii;

            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

    }
}
