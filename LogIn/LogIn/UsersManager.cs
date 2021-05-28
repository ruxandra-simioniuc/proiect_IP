using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            if (mail == "" || parola == "")
                return -1;
            _conn.Open();

            string parola_encrypt = HashString(parola);
            Console.WriteLine(parola_encrypt);

            string sql = "SELECT id from utilizatori where mail=@mail and parola=@parola;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = _conn;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@parola", parola_encrypt);
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


            if (parola != parola_2 || nume == "" || prenume == "" || mail == "" || parola == "" || parola_2 == "")
            {
                command.Dispose();
                _conn.Close();
                return false;

            }
            else
            {
                string parola_encrypt = HashString(parola);

                command.CommandText = "INSERT INTO utilizatori (nume, prenume, mail, parola) VALUES ( @nume, @prenume, @mail, @parola)";
                command.Parameters.AddWithValue("@nume", nume);
                command.Parameters.AddWithValue("@prenume", prenume);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@parola", parola_encrypt);
                command.Prepare();
                command.ExecuteNonQuery();
                command.Dispose();
                _conn.Close();
                return true;

            }
        }

        /// <summary>
        /// Returns the hash of a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string HashString(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            byte[] buf = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                buf[i] = (byte)str[i];
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }
    }
}
