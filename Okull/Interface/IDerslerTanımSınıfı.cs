using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okull
{
    interface IDerslerTanımSınıfı
    {
        public Enumlar.DersNo DersNo { get; set; }

        public string Ad { get; set; }

        public string Aciklama { get; set; }

        public string OgretimGorevlisi { get; set; }


    }
}
