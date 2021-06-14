using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okull
{
    interface IOgrenciDerslerSınıfı
    {
        public Enumlar.DersNo DersNo { get; set; }

        public string OgrenciNo { get; set; }
    }
}
