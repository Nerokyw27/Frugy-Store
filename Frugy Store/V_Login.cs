using Frugy_Store.Controller;
using Frugy_Store.Helpers;
using Frugy_Store.Model;
using Frugy_Store.Views.View_Admin;
using Frugy_Store.Views.View_Kasir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frugy_Store
{
    public partial class V_Login : Form
    {

        public V_Login()
        {
            InitializeComponent();
            tbPasswordLgn.UseSystemPasswordChar = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            // 2. Ubah ukuran form mengikuti ukuran area kerja layar pengguna
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            // 3. (Opsional) Kunci supaya user gak bisa ubah ukurannya
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsernameLgn.Text;
            string password = tbPasswordLgn.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username & Password harus diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                M_Akun user = new M_Akun
                {
                    Username = username,
                    Password = password
                };

                var auth = new AuthController().Login(user);

                if (auth != null)
                {
                    MessageBox.Show($"Login berhasil. Selamat datang {auth.Username}", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AppSession.SetUser(auth);

                    if (auth.Role == RoleAkun.admin)
                    {
                        V_BerandaAdmin admin = new V_BerandaAdmin();
                        admin.FormClosed += (s, args) => this.Close();
                        admin.Show();
                        this.Hide();
                    }
                    else if (auth.Role == RoleAkun.kasir)
                    {
                        V_BerandaKasir kasir = new V_BerandaKasir(auth.AkunId);
                        kasir.FormClosed += (s, args) => this.Close();
                        kasir.Show();
                        this.Hide();
                    }
                    // Handle unknown roles
                    else
                    {
                        MessageBox.Show("Role tidak dikenali!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // This else block belongs to 'if (auth != null)'
                    MessageBox.Show("Cek kembali apakah password atau username salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login gagal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void V_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
