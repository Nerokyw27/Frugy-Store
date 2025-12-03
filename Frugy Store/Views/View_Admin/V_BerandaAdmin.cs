using Frugy_Store.Interface;
using Frugy_Store.Views.View_Kasir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frugy_Store.Views.View_Admin
{
    public partial class V_BerandaAdmin : Form
    {
        //private IProduk C_Produk;
        //public V_BerandaAdmin(IProduk produkInterface)
        public V_BerandaAdmin()
        {
            InitializeComponent();
            //C_Produk = produkInterface;

        }

        private void V_BerandaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnProdukAdm_Click(object sender, EventArgs e)
        {
            V_TampilanProduk tampilanProduk = new V_TampilanProduk();
            tampilanProduk.FormClosed += (s, args) => this.Close();
            tampilanProduk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_ManajemenKasir tampilanKasir = new V_ManajemenKasir();
            tampilanKasir.FormClosed += (s, args) => this.Close();
            tampilanKasir.Show();
            this.Hide();
        }

        private void btnTransaksiAdm_Click(object sender, EventArgs e)
        {
            V_PembelianProduk tampilanProduk = new V_PembelianProduk();
            tampilanProduk.FormClosed += (s, args) => this.Close();
            tampilanProduk.Show();
            this.Hide();
        }

        private void btnLaporanAdm_Click(object sender, EventArgs e)
        {
            V_LaporanAdm laporanAdm = new V_LaporanAdm();
            laporanAdm.FormClosed += (s, args) => this.Close();
            laporanAdm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            V_Login logout = new V_Login();
            logout.FormClosed += (s, args) => this.Close();
            logout.Show();
            this.Hide();
        }
    }
}
