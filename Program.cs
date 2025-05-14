using EmlakciAppLib;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //KiralıkEv class'ından bir nesne türetildi.

            KiralikEv ke = new KiralikEv(500, 600, 3, "Kiralik Ev", 100, 80);          //ke: Nesnesin referansıdır. Nesneye ulaşmakta kullanılır. 
            KiralikEv ke1 = new KiralikEv(800, 900, 2, "Kiralik Ev", 120, 90);         //KiralıkEv: Referansın veri tipidir. Her class aynı zamanda bir veri tipidir.
            KiralikEv ke2 = new KiralikEv(10000, 10000, 4, "Kiralik Ev", 200, 100);    //new: Nesne üretmek için kullanılan anahtar sözcüktür. Nesneler HEAP bölgesinde oluşturulur.   

            var se = new SatilikEv(400, 3, "Satılık Ev", 110, 60);
            var se1 = new SatilikEv(700, 2, "Satılık Ev", 120, 70);
            var se2 = new SatilikEv(900, 4, "Satılık Ev", 140, 80);

            Ev[] evler = { ke, ke1, ke2, se, se1, se2 };


            //Name Hiding ile Yapılanlar

            foreach (Ev ev in evler)
            {
                //    if (ev is KiralikEv)
                //    {
                //        KiralikEv kev = (KiralikEv) ev;  //Tür dönüşümü
                //        Console.WriteLine(kev.EvBilgileri());
                //    }
                //    else
                //    {
                //        SatilikEv sev = (SatilikEv) ev;  //Tür dönüşümü
                //        Console.WriteLine(sev.EvBilgileri());
                //    }

                Console.WriteLine(ev.EvBilgileri());
                Console.WriteLine("-------------------");
            }

        }
    }
}


