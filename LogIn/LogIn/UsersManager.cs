using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace LogIn
{
    public class UsersManager
    {
        private MySqlConnection _conn;
        public UsersManager(MySqlConnection conn)
        {
            _conn = conn;
        }
        public int Logare(string mail, string parola)
        {
            _conn.Open();
            string sql = "SELECT id from utilizatori where mail=@mail and parola=@parola;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@parola", parola);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (!rdr.Read())
            {
                cmd.Dispose();
                _conn.Close();
                return -1;
            }
            else
            {
                int a= Int32.Parse(rdr[0].ToString());
                cmd.Dispose();
                _conn.Close();
                return a;
            }




        }
        public bool signUp(string nume, string prenume, string mail, string parola, string parola_2)
        {

            _conn.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = _conn;


            if (parola != parola_2)
            {
                command.Dispose();
                _conn.Close();
                return false;

            }
            else
            {

                command.CommandText = "INSERT INTO utilizatori (nume, prenume, mail, parola) VALUES ( @nume, @prenume, @mail, @parola)";
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@prenume", prenume);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@parola", parola);
                command.Prepare();
                command.ExecuteNonQuery();
                command.Dispose();
                _conn.Close();
                return true;

            }
        }
    }
}
