/**************************************************************************
 *                                                                        *
 *  File:        Info_Zbor.cs                                             *
 *  Autor:       Teodor Colipca                                           *         
 *  Functionalitate:  Retine informatiile despre un anumit zbor           *
 *                                                                        *    
 *                                                                        *
 **************************************************************************/


using System;

namespace SelectareZbor
{
    /// <summary>
    /// clasa ce retine informatiile unui zbor
    /// </summary>
    public class Info_Zbor
    {
        #region Private Member Variables
        private DateTime _ora_sosirii;
        private DateTime _ora_plecarii;
        private String _interval;
        private int _pret;
        private String _oras_plecare;
        private String _oras_sosire;
        #endregion
        #region Constructors
        /// <summary>
        /// constructorul clasei ce primeste ca parametrii informatiile zborului
        /// </summary>
        /// <param name="ora_plecarii"></param>
        /// <param name="ora_sosirii"></param>
        /// <param name="pret"></param>
        /// <param name="oras_plecare"></param>
        /// <param name="oras_sosire"></param>
        public Info_Zbor(String ora_plecarii, String ora_sosirii, int pret, string oras_plecare, string oras_sosire)
        {
            _oras_plecare = oras_plecare;
            _oras_sosire = oras_sosire;
            string[] sosire = ora_sosirii.Split(':');
            string[] plecare = ora_plecarii.Split(':');

            _ora_sosirii = new DateTime(2021, 12, 12, int.Parse(sosire[0]), int.Parse(sosire[1]), 0);
            _ora_plecarii = new DateTime(2021, 12, 12, int.Parse(plecare[0]), int.Parse(plecare[1]), 0);
            int ore = (_ora_sosirii - _ora_plecarii).Hours;
            int minute = (_ora_sosirii - _ora_plecarii).Minutes;
            _interval = ore.ToString() + ":" + minute.ToString();
            _pret = pret;
        }
        #endregion
        #region Public Properties
        /// <summary>
        /// returneaza ora la care soseste avionul
        /// </summary>
        public String getOraSosire
        {
            get
            {
                return _ora_sosirii.ToString("HH:mm");
            }
        }
        /// <summary>
        /// returneaza ora la care pleaca avionul
        /// </summary>
        public String getOraPlecare
        {
            get
            {
                return _ora_plecarii.ToString("HH:mm");
            }
        }
        /// <summary>
        /// returneaza orasul destinatie
        /// </summary>
        public String getOrasSosire
        {
            get
            {
                return _oras_sosire;
            }
        }
        /// <summary>
        /// returneaza orasul de plecare
        /// </summary>
        public String getOrasPlecare
        {
            get
            {
                return _oras_plecare;
            }
        }
        /// <summary>
        /// returneaza durata zborului
        /// </summary>
        public String getInterval
        {
            get
            {
                return _interval;
            }
        }
        /// <summary>
        /// returneaza pretul minim al unui bilet
        /// </summary>
        public int getPret
        {
            get
            {
                return _pret;
            }
        }
        #endregion

    }
}