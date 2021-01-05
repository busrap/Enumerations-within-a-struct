using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struch_enum
{
    class Ogrenci    /// class ve struct arasında ki fark "ogrenci class'ı miras olarak alına bilir fakat Ders(struct) miras olarak alınamaz
    {
        public Ogrenci()
        {
            Dersler = new List<Ders>();
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public List<Ders> Dersler { get; set; }
        public  Alan alani{ get; set; }
        public Renk rk { get; set; }





        public decimal Ortalama
           
        {
            get
            {
                decimal toplam = 0;
                foreach (Ders not in Dersler)
                {
                    toplam += not.Ortalama;
                }
                return toplam / Dersler.Count();

            }

        }
       

    }
    enum Renk
    {
        kırmızı, sarı, mavi, lacivert, mor, pembe

    }

    enum Alan
    {
        EsitAgirlik,
        sayisal,
        sozel,
        dil
    }

    struct Ders
    {
        public string DersAdi { get; set; }
        public decimal Vize { get; set; }
        public decimal Final { get; set; }
        public decimal Ortalama
        {
            get
            {
                return Vize * 0.4m + Final * 0.6m;
            }
        }

    }
}
