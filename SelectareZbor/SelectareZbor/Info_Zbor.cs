using System;

namespace SelectareZbor
{
    public class Info_Zbor
    {
        private DateTime _ora_sosirii;
        private DateTime _ora_plecarii;
        private String _interval;
        private int _pret;
        private String _oras_plecare;
        private String _oras_sosire;
        public Info_Zbor(String ora_plecarii, String ora_sosirii, int pret, string oras_plecare, string oras_sosire)
        {
            _oras_plecare = oras_plecare;
            _oras_sosire = oras_sosire;
            string[] sosire = ora_sosirii.Split(':');
            string[] plecare = ora_plecarii.Split(':');

            _ora_sosirii = new DateTime(2021, 12, 12, int.Parse(sosire[0]), int.Parse(sosire[1]), 0);
            _ora_plecarii = new DateTime(2021, 12, 12, int.Parse(plecare[0]), int.Parse(plecare[1]), 0);
            int ore = (_ora_sosirii - _ora_plecarii).Hours;
            //150->2:30
            int minute = (_ora_sosirii - _ora_plecarii).Minutes;
            _interval = ore.ToString() + ":" + minute.ToString();
            _pret = pret;
        }
        public String getOraSosire
        {
            get
            {
                return _ora_sosirii.ToString("HH:mm");
            }
        }
        public String getOraPlecare
        {
            get
            {
                return _ora_plecarii.ToString("HH:mm");
            }
        }
        public String getOrasSosire
        {
            get
            {
                return _oras_sosire;
            }
        }
        public String getOrasPlecare
        {
            get
            {
                return _oras_plecare;
            }
        }
        public String getInterval
        {
            get
            {
                return _interval;
            }
        }
        public int getPret
        {
            get
            {
                return _pret;
            }
        }

    }
}