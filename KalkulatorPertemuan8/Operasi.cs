using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPertemuan8
{
    public class Operasi
    {
        public string Hasil { get; set; }

        public string Penjumlahan(int a, int b)
        {
            return Hasil = "Hasil penjumlahan " + a + " + " + b + " = " + (a + b);
        }

        public string Pengurangan(int a, int b)
        {
            return Hasil = "Hasil pengurangan " + a + " - " + b + " = " + (a - b);
        }

        public string Perkalian(int a, int b)
        {
            return Hasil = "Hasil perkalian " + a + " * " + b + " = " + (a * b);
        }

        public string Pembagian(int a, int b)
        {
            return Hasil = "Hasil pembagian " + a + " / " + b + " = " + (a / b);
        }
    }
}
