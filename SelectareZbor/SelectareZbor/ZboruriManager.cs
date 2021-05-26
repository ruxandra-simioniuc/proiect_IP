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
        public List<String> GetDestinationBasedOnDate(string Date)
        {
            _conn.Open();
            List<String> destinatii = new List<String>();
            string sql = "SELECT destinatie from zboruri where data_zbor=@data;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@data", Date);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(!rdr.Read())
            {
                destinatii.Add(rdr.GetString(0));
            }
            return destinatii;


        }

    }
}
