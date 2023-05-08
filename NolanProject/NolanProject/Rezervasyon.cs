using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NolanProject
{

    // Rezervasyon sınıfı
    class Rezervasyon
    {
        public Film Film { get; set; }
        public Seans Seans { get; set; }
        public Koltuk Koltuk { get; set; }
        public string OdemeSekli { get; set; }

        public decimal Tutar()
        {
            return 50.00m; // Tutar
        }
    }
}