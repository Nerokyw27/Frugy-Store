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
    public partial class V_ManajemenKasir : Form
    {
        private C_Kasir _kasirController;
        public V_ManajemenKasir()
        {
            InitializeComponent();
            _kasirController = new C_Kasir();
            LoadKasir();
        }

        private void btnTambahKasir_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var tambah = new V_TambahKasir())
            {
                tambah.FormClosed += (s, args) =>
                {
                    try
                    {
                        this.Show();
                        LoadKasir();
                    }
                    catch { }
                };

                tambah.ShowDialog();
            }
        }

        private void LoadKasir()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                var list = _kasirController.GetAllKasir();
                foreach (var akun in list)
                {
                    Panel panel = new Panel
                    {
                        Size = new Size(450, 279),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(6),
                        Tag = akun.AkunId
                    };

                    // Nama + role (header)
                    Label lblNama = new Label
                    {
                        Text = akun.Username ?? "-",
                        Font = new Font("Poppins", 16.2F, FontStyle.Regular),
                        Location = new Point(17, 28),
                        AutoSize = true
                    };


                    // Email
                    Label lblEmailHeading = new Label
                    {
                        Text = "Email :",
                        Font = new Font("Poppins", 16.2F, FontStyle.Regular),
                        Location = new Point(17, 99),
                        AutoSize = true
                    };

                    Label lblEmailValue = new Label
                    {
                        Text = akun.Email ?? "-",
                        Font = new Font("Poppins", 16.2F, FontStyle.Regular),
                        Location = new Point(133, 99),
                        AutoSize = true
                    };

                    // No HP
                    Label lblNoHpHeading = new Label
                    {
                        Text = "No HP :",
                        Font = new Font("Poppins", 16.2F, FontStyle.Regular),
                        Location = new Point(17, 167),
                        AutoSize = true
                    };

                    Label lblNoHpValue = new Label
                    {
                        Text = akun.NoHp ?? "-",
                        Font = new Font("Poppins", 16.2F, FontStyle.Regular),
                        Location = new Point(136, 167),
                        AutoSize = true
                    };

                    // Buttons edit & hapus
                    Button btnEdit = new Button
                    {
                        Text = "Edit",
                        Size = new Size(84, 35),
                        Location = new Point(254, 225),
                        Tag = akun.AkunId
                    };
                    btnEdit.Click += (s, e) =>
                    {
                        try
                        {
                            this.Hide();
                            //akun.AkunId
                            using (var edit = new V_EditKasir(akun.AkunId))
                            {
                                edit.FormClosed += (se, ea) =>
                                {
                                    try
                                    {
                                        if (edit.DialogResult == DialogResult.OK)
                                            LoadKasir();
                                        this.Show();
                                    }
                                    catch { }
                                };

                                edit.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Gagal membuka form edit: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            try { this.Show(); } catch { }
                        }
                    };

                    Button btnHapus = new Button
                    {
                        Text = "Hapus",
                        Size = new Size(84, 35),
                        Location = new Point(354, 225),
                        Tag = akun.AkunId
                    };
                    btnHapus.Click += (s, e) =>
                    {
                        var id = (int)((Button)s).Tag;
                        var confirm = MessageBox.Show("Hapus akun kasir ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            bool ok = _kasirController.DeleteKasir(id);
                            if (ok)
                            {
                                LoadKasir();
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus akun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    };

                    // tambahkan control ke panel
                    panel.Controls.Add(lblNama);
                    panel.Controls.Add(lblEmailHeading);
                    panel.Controls.Add(lblEmailValue);
                    panel.Controls.Add(lblNoHpHeading);
                    panel.Controls.Add(lblNoHpValue);
                    panel.Controls.Add(btnEdit);
                    panel.Controls.Add(btnHapus);

                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data kasir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembaliMK_Click(object sender, EventArgs e)
        {
            V_BerandaAdmin berandaAdmin = new V_BerandaAdmin();
            berandaAdmin.FormClosed += (s, args) => this.Close();
            berandaAdmin.Show();
            this.Hide();
        }
    }
}
