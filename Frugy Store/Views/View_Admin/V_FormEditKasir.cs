using Frugy_Store.Controller;
using Frugy_Store.Model;
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
    public partial class V_FormEditKasir : Form
    {
        private M_Kasir kasirData;
        private C_Kasir cKasir = new C_Kasir();

        public V_FormEditKasir(M_Kasir kasir)
        {
            InitializeComponent();

            kasirData = kasir;

            // LEFT SIDE = DATA LAMA
            txtOldUsername.Text = kasir.Username;
            txtOldPassword.Text = kasir.Password;
            txtOldEmail.Text = kasir.Email;
            txtOldNoHp.Text = kasir.NoHp;
            txtOldNamaLengkap.Text = kasir.NamaLengkap;
            txtRole.Text = kasir.Role;
            txtStatusEdit.Text = kasir.Status;
            txtMulaiBekerjaEdit.Text = kasir.MulaiBekerja.ToShortDateString();

            // RIGHT SIDE = DATA BARU (default isi lama)
            txtNewUsername.Text = kasir.Username;
            txtNewPassword.Text = kasir.Password;
            txtNewEmail.Text = kasir.Email;
            txtnewNOHP.Text = kasir.NoHp;
            txtNewNamaLengkap.Text = kasir.NamaLengkap;
        }

        private void btnSimpanEdit_Click(object sender, EventArgs e)
        {
            // Update berdasarkan input baru
            kasirData.Username = txtNewUsername.Text;
            kasirData.Password = txtNewPassword.Text;
            kasirData.Email = txtNewEmail.Text;
            kasirData.NoHp = txtnewNOHP.Text;
            kasirData.NamaLengkap = txtNewNamaLengkap.Text;

            bool result = cKasir.UpdateKasir(kasirData);

            if (result)
            {
                MessageBox.Show("Data kasir berhasil diperbarui!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan perubahan!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
