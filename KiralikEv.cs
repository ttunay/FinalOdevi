using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciAppLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(double kira, double depozito, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            this.Kira = kira;
            this.Depozito = depozito;
        }

        public double Kira { get; set; }
        public double Depozito { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        //}

        public override string EvBilgileri()     
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat no:{this.Katno}\nAlan:{this.Alan}\nSemt:{this.Semt}\nBüyüklük:{this.Buyukluk}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        }
    }
}


