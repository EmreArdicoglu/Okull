using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okull
{
    public class idariPersonel : IidariPersonel
    {
        public string KimlikNo { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Enumlar.Gorevler Gorev { get; set; }
    }
}
