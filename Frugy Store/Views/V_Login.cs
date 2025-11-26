using Frugy_Store.Controller;
using Frugy_Store.Helpers;
using Frugy_Store.Interface;
using Frugy_Store.Model;
using Frugy_Store.Views.View_Admin;
using Frugy_Store.Views.View_Kasir;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frugy_Store.Views
{
    public partial class V_Login : Form
    {
        private AuthController authController;
        private readonly IProduk produkInterface;
        public V_Login()
        {
            InitializeComponent();
            authController = new AuthController();
            produkInterface = new C_Produk();

        }

        private void V_Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsernameLgn.Text;
            string password = tbPasswordLgn.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username & Password harus diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string hashPassword = PasswordHelper.HashPassword(password);
                M_Akun user = new M_Akun
                {
                    Username = username,
                    Password = hashPassword
                };

                var auth = authController.Login(user);
                if (auth != null)
                {
                    MessageBox.Show($"Login berhasil. Selamat datang {user.Username}", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AppSession.SetUser(auth);

                    if (AppSession.CurrentUser.Role == RoleAkun.admin)
                    {
                        V_BerandaAdmin admin = new V_BerandaAdmin(produkInterface);
                        admin.FormClosed += (s, args) => this.Close();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        V_BerandaKasir kasir = new V_BerandaKasir();
                        kasir.FormClosed += (s, args) => this.Close();
                        kasir.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Cek kembali apakah password atau username salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login gagal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
