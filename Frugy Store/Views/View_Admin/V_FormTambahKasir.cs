using Frugy_Store.Model;
using Frugy_Store.Controller;
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
    public partial class V_FormTambahKasir : Form
    {
        public V_FormTambahKasir()
        {
            InitializeComponent();
        }

        private void btnSimpanKasir_Click(object sender, EventArgs e)
        {
            C_Kasir controller = new C_Kasir();
            M_Kasir kasir = new M_Kasir
            {
                NamaLengkap = TBNamaTambahKasir.Text,
                Username = TBUsnTambahKasir.Text,
                Password = TBPwTambahKasir.Text,
                Status = LBStatus.Text,
                MulaiBekerja = DateTime.Parse(LBMulaiBekerja.Text)
            };

            if (controller.InsertKasir(kasir))
            {
                MessageBox.Show("Kasir berhasil ditambahkan!");
                this.Close();
            }
        }
    }
}
