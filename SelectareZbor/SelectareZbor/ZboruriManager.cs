using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SelectareZbor
{
    public class ZboruriManager
    {
        private MySqlConnection _conn;
        public ZboruriManager(MySqlConnection conn)
        {
            _conn = conn;
        }
        
        //private string TransformDate()
        //preia destinatiile posibile in ziua aleasa
        public List<String> GetDestinationBasedOnDate(string Date)
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
        //cand se apasa butonul ala de cautare zbor se va apela functia asta
        //returnez o lista cu id-urile zborurilor disponibile, aceasta lista trebuie trimisa mai departe spre urmatorul panel
        //adica cel in care se vad zborurile si fac un query pe baza listei.
        public List<int> GetFlights(string destination, string Date)
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
            while(rdr.Read())
            {
                flights.Add(rdr.GetInt32(0));
            }
            cmd.Dispose();
            _conn.Close();
            return flights;

        }

        public string GetData(string id)
        {
            _conn.Open();
            string sql = "SELECT data_zbor from zboruri where id_zbor=@id;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            string raspuns = "";
            if (rdr.Read())
                raspuns = rdr.GetString(0);
            cmd.Dispose();
            _conn.Close();
            return raspuns;
        }

        public string GetDestinatie(string id)
        {
            _conn.Open();
            string sql = "SELECT destinatie from zboruri where id_zbor=@id;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            string raspuns = "";
            if (rdr.Read())
                raspuns = rdr.GetString(0);
            cmd.Dispose();
            _conn.Close();
            return raspuns;
        }

        public List<Info_Zbor> GetInfo(List<int> id)
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

    }
}
