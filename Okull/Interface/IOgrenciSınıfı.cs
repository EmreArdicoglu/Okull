using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okull
{
    interface IOgrenciSınıfı
    {
        public string OgrenciNo { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarih { get; set; }
        
        public Enumlar.Bolumler Bolum { get; set; }

        public Enumlar.Sınıfı Sınıf { get; set; }

        public string NotOrtalama { get; set; }
    }
}
