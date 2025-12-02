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
    public partial class V_EditKasir : Form
    {
        private readonly int _akunId;
        private readonly C_Kasir _kasirController;
        private M_Akun _akun;

        public V_EditKasir(int akunId)
        {
            InitializeComponent();
            _akunId = akunId;
            _kasirController = new C_Kasir();

            // events
            Load += V_EditKasir_Load;
            btnSimpanEK.Click += BtnSimpanEK_Click;
            btnBatalEK.Click += BtnBatalEK_Click;
            button3.Click += BtnKembali_Click;

            tbNewPass.UseSystemPasswordChar = true;
        }

        private void V_EditKasir_Load(object sender, EventArgs e)
        {
            try
            {
                _akun = _kasirController.GetKasirById(_akunId);
                if (_akun == null)
                {
                    MessageBox.Show("Akun kasir tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }


                tbNewNama.Text = _akun.NamaLengkap;
                tbNewUsn.Text = _akun.Username;
                tbNewEmail.Text = _akun.Email;
                tbNewNoHP.Text = _akun.NoHp;
                tbNewPass.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data kasir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void BtnSimpanEK_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(tbNewNama.Text) || string.IsNullOrWhiteSpace(tbNewUsn.Text))
                {
                    MessageBox.Show("Nama lengkap dan username harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _akun.NamaLengkap = tbNewNama.Text.Trim();
                _akun.Username = tbNewUsn.Text.Trim();
                if (!string.IsNullOrEmpty(tbNewPass.Text))
                {
                    _akun.Password = tbNewPass.Text;
                }
                _akun.Email = tbNewEmail.Text.Trim();
                _akun.NoHp = tbNewNoHP.Text.Trim();

                bool ok = _kasirController.UpdateKasir(_akun);
                if (ok)
                {
                    MessageBox.Show("Perubahan akun kasir tersimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan perubahan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menyimpan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBatalEK_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Batalkan perubahan? Semua perubahan yang belum disimpan akan hilang.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void BtnKembali_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
