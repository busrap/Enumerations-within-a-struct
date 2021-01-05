using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struch_enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "selma";
            ogr.Soyadi = "kutlu";
            Ders ders = new Ders { DersAdi = "matematik", Final = 50, Vize = 60 };
            Ders ders2 = new Ders { DersAdi = "Fizik", Final = 80, Vize = 90 };
            Ders ders3 = new Ders { DersAdi = "kimya", Final = 60, Vize = 80 };
            ogr.alani = Alan.sayisal;

            switch (ogr.rk)
            {
                case renk.kırmızı:
                    

                    break;
                case renk.sarı:
                    break;
                case renk.mavi:
                    break;
                case renk.lacivert:
                    break;
                case renk.mor:
                    break;
                case renk.pembe:
                    break;
                default:
                    break;
            }

            ogr.Dersler.Add(ders);
            ogr.Dersler.Add(ders2);
            ogr.Dersler.Add(ders3);


        }
        // struct class a göre daha kolay çalışa bilen bir nesnedir
        //struct lar ayrıca tanımlanan yapılar değildir oluşturulan calass'ın altında üstünde bir yerinde tanımlanan yapılardır.
    }
}
