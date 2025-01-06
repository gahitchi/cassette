using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cassetta
{
    class Cassetta
    {

        private OggSeg ogg;
        private string pin;
        private string uPin;

        public string Pin
        {
            get { return pin; }
        }
        public string UPin
        {
            get { return uPin; }
            set { uPin = value; }
        }

        public void Inserire(OggSeg oggT)
        {
            if (uPin == Pin)
            {
                ogg = oggT;
            }
        }

        public OggSeg Rimuovere()
        {//..bisogna passare il pin
            OggSeg oggT = ogg;
            ogg = null;
            return oggT;
        }

        public float ValAss()
        {
            if (ogg != null)
                return ogg.CalcValAss();
            else
                return 0;
        }

        public string Tipologia1()
        {
            if (ogg is Doc) return "documento legale";
            if (ogg is Gioiello) return "gioiello prezioso";
            if (ogg is Chiave) return "chiave";
            if (ogg is OggSeg) return "oggetto segreto";

            return "oggetto sconosciuto";
        }

        public string Tipologia2()
        {
            return ogg.GetType().ToString();
        }

        public Cassetta(string pin)
        {
            pin = Pin;
        }

    }
}
