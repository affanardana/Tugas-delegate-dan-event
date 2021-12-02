using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorPertemuan8
{
    public partial class FrmCalculator : Form
    {
        public delegate void CreateUpdateEventHandler(Operasi ops);

        public event CreateUpdateEventHandler OnResult;

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            var operasi = cmbOperasi.Text;

            int nilaiA = Convert.ToInt32(txtNilaiA.Text);
            int nilaiB = Convert.ToInt32(txtNilaiB.Text);

            Operasi ops = new Operasi();

            if (operasi == "Penjumlahan")
            {
                ops.Penjumlahan(nilaiA, nilaiB);

                OnResult(ops);
            }
            else if (operasi == "Pengurangan")
            {
                ops.Pengurangan(nilaiA, nilaiB);

                OnResult(ops);
            }
            else if (operasi == "Perkalian")
            {
                ops.Perkalian(nilaiA, nilaiB);

                OnResult(ops);
            }
            else if (operasi == "Pembagian")
            {
                ops.Pembagian(nilaiA, nilaiB);

                OnResult(ops);
            }
        }
    }
}
