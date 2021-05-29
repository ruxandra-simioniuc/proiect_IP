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
    /// <summary>
    /// 
    /// </summary>
    public class UsersManager
    {
        #region Private Member Variables
        /// <summary>
        /// variabila ce retine conexiunea
        /// </summary>
        private MySqlConnection _conn;
        #endregion
        #region Private Methods
        /// <summary>
        /// Returneaza parola criptata
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
        #endregion
        #region Constructors
        /// <summary>
        /// Constructorul clasei ce primeste ca parametru conexiunea la baza de date
        /// </summary>
        /// <param name="conn"></param>
        public UsersManager(MySqlConnection conn)
        {
            _conn = conn;
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Metoda ce primeste informatiile pentru logare si verifica daca exista un utilizator cu aceste date
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="parola"></param>
        /// <returns></returns>
        public int Logare(string mail, string parola)
        {
            try
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
                    int a = Int32.Parse(rdr[0].ToString());
                    cmd.Dispose();
                    _conn.Close();
                    return a;
                }
            }catch(Exception e)
            {
                return -2;
            }

        }
        /// <summary>
        /// metoda ce creeaza un nou utilizator in baza de date
        /// </summary>
        /// <param name="nume"></param>
        /// <param name="prenume"></param>
        /// <param name="mail"></param>
        /// <param name="parola"></param>
        /// <param name="verificare_parola"></param>
        /// <returns></returns>
        public int signUp(string nume, string prenume, string mail, string parola, string verificare_parola)
        {
            try
            {
                _conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = _conn;


                if (parola != verificare_parola || nume == "" || prenume == "" || mail == "" || parola == "" || verificare_parola == "")
                {
                    command.Dispose();
                    _conn.Close();
                    return -1;

                }
                else
                {
                    string parola_encrypt = HashString(parola);
                    try
                    {
                        command.CommandText = "INSERT INTO utilizatori (nume, prenume, mail, parola) VALUES ( @nume, @prenume, @mail, @parola)";
                        command.Parameters.AddWithValue("@nume", nume);
                        command.Parameters.AddWithValue("@prenume", prenume);
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@parola", parola_encrypt);
                        command.Prepare();
                        command.ExecuteNonQuery();
                        command.Dispose();
                        _conn.Close();
                        return 1;
                    }
                    catch (Exception e)
                    {
                        command.Dispose();
                        _conn.Close();
                        return 0;
                    }


                }
            }
            catch (Exception e)
            {
                return -2;
            }
        }
        #endregion

    }
}
