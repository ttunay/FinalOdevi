using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakciAppLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }

        public SatilikEv(double satisfiyat, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            Satisfiyat = satisfiyat;
        }

        public double Satisfiyat { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        //}

        public override string EvBilgileri()         
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat no:{this.Katno}\nAlan:{this.Alan}\nSemt:{this.Semt}\nBüyüklük:{this.Buyukluk}\nKira:{this.Satisfiyat}";
        }
    }
}

