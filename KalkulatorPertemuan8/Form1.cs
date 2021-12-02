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
    public partial class FrmHasilHitung : Form
    {
        public FrmHasilHitung()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwHasil.View = View.List;
        }

        private void InitializeListView()
        {
            lvwHasil.View = View.Details;
        }

        private void FrmOperasi_OnResult(Operasi ops)
        {
            lvwHasil.Items.Add(ops.Hasil);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmCalculator frmCalc = new FrmCalculator();

            frmCalc.OnResult += FrmOperasi_OnResult;

            frmCalc.ShowDialog();
        }
    }
}
