using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okull
{
    public class PersonelSınıfı : IPersonelSınıfı
    {
        public string KimlikNo { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Enumlar.Departmanlar Departman { get; set; }
        public Enumlar.Gorevler Gorev { get; set; }
        public DateTime BaslamaTarihi { get; set; }
    }
}
