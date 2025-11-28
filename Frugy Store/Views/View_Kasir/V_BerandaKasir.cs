using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frugy_Store.Views.View_Kasir
{
    public partial class V_BerandaKasir : Form
    {
        private int _idKasir;
        public V_BerandaKasir(int idKasir)
        {
            InitializeComponent();
            _idKasir = idKasir;
        }

        private void btnTransaksiKsr_Click(object sender, EventArgs e)
        {
            V_TransaksiKasir transaksiKasir = new V_TransaksiKasir(_idKasir);
            transaksiKasir.FormClosed += (s, args) => this.Close();
            transaksiKasir.Show();
            this.Hide();
        }

        private void btnLaporanKsr_Click(object sender, EventArgs e)
        {
            V_LaporanKasir laporanKasir = new V_LaporanKasir();
            laporanKasir.FormClosed += (s, args) => this.Close();
            laporanKasir.Show();
            this.Hide();
        }

        private void V_BerandaKasir_Load(object sender, EventArgs e)
        {

        }
    }
}
