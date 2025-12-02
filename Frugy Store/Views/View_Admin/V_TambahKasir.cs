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
    public partial class V_TambahKasir : Form
    {
        private readonly C_Kasir _kasirController;

        public V_TambahKasir()
        {
            InitializeComponent();
            _kasirController = new C_Kasir();
            tbPasswordTK.UseSystemPasswordChar = true;

            btnBatalTK.Click += BtnBatalTK_Click;
            btnKembaliTK.Click += BtnKembaliTK_Click;
        }

        private void btnTambahTK_Click(object sender, EventArgs e)
        {
            try
            {
                string namaLengkap = tbNamaLengkapTK.Text.Trim();
                string username = tbUsernameTK.Text.Trim();
                string password = tbPasswordTK.Text;
                string email = tbEmailTK.Text.Trim();
                string noHp = tbNoHpTK.Text.Trim();

                if (string.IsNullOrWhiteSpace(namaLengkap) ||
                    string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Nama, username, dan password harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                M_Akun akunBaru = new M_Akun
                {
                    NamaLengkap = namaLengkap,
                    Username = username,
                    Password = password,
                    Role = RoleAkun.kasir,
                    Email = email,
                    NoHp = noHp
                };

                _kasirController.TambahAkunKasir(akunBaru);

                MessageBox.Show("Akun kasir berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menambah kasir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBatalTK_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Batalkan penambahan kasir? Data yang sudah diisi akan tetap ada jika memilih Tidak.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void BtnKembaliTK_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
