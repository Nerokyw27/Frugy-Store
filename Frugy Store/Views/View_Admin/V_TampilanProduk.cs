using Frugy_Store.Controller;
using Frugy_Store.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Frugy_Store.Views.View_Admin
{
    public partial class V_TampilanProduk : Form
    {
        private C_Produk _produkController;


        public V_TampilanProduk()
        {
            InitializeComponent();
            _produkController = new C_Produk();
            LoadProduk();
        }

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (V_TambahProduk tambahProdukForm = new V_TambahProduk())
            {
                tambahProdukForm.FormClosed += (s, args) =>
                {
                    try
                    {
                        this.Show();
                        LoadProduk();
                    }
                    catch { }
                };

                tambahProdukForm.ShowDialog();
            }
        }

        private void LoadProduk()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                var produklist = _produkController.GetProduk();

                foreach (var produk in produklist)
                {
                    // panel container
                    Panel panel = new Panel
                    {
                        Size = new Size(1418, 149),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(3),
                        Tag = produk.IdProduk
                    };

                    // picture
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(143, 118),
                        Location = new Point(22, 18),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.WhiteSmoke
                    };
                    if (produk.Image != null && produk.Image.Length > 0)
                    {
                        try
                        {
                            using var ms = new MemoryStream(produk.Image);
                            pictureBox.Image = Image.FromStream(ms);
                        }
                        catch
                        {
                            pictureBox.Image = null;
                        }
                    }


                    Label lblStokHeading = new Label
                    {
                        Text = "Stok :",
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(183, 83),
                        AutoSize = true
                    };

                    Label lblTglHeading = new Label
                    {
                        Text = "Tanggal Masuk",
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(439, 18),
                        AutoSize = true
                    };

                    Label lblKdlHeading = new Label
                    {
                        Text = "Kadaluarsa",
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(728, 18),
                        AutoSize = true
                    };

                    Label lblHargaHeading = new Label
                    {
                        Text = "Harga",
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(985, 18),
                        AutoSize = true
                    };

                    // Value labels (isi...) - these change per product
                    Label lblNamaValue = new Label
                    {
                        Text = produk.NamaProduk ?? "-",
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(183, 18),
                        AutoSize = true
                    };

                    Label lblStokValue = new Label
                    {
                        Text = produk.Stok.ToString(),
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(254, 83),
                        AutoSize = true
                    };

                    Label lblTglValue = new Label
                    {
                        Text = produk.TanggalMasuk != default ? produk.TanggalMasuk.ToString("yyyy-MM-dd") : "-",
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(439, 83),
                        AutoSize = true
                    };

                    Label lblKdlValue = new Label
                    {
                        Text = produk.Kadaluarsa != default ? produk.Kadaluarsa.ToString("yyyy-MM-dd") : "-",
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(728, 83),
                        AutoSize = true
                    };

                    Label lblHargaValue = new Label
                    {
                        Text = produk.Harga.ToString("N0"),
                        Font = new Font("Poppins", 13.8F, FontStyle.Regular),
                        Location = new Point(985, 83),
                        AutoSize = true
                    };

                    // Buttons
                    Button btnEdit = new Button
                    {
                        Text = "Edit",
                        Location = new Point(1227, 64),
                        Size = new Size(71, 34),
                        Tag = produk.IdProduk
                    };
                    btnEdit.Click += (s, e) =>
                    {
                        MessageBox.Show("Implement edit form untuk mengubah produk.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    };

                    Button btnDelete = new Button
                    {
                        Text = "Delete",
                        Location = new Point(1319, 64),
                        Size = new Size(71, 34),
                        Tag = produk.IdProduk
                    };
                    btnDelete.Click += (s, e) =>
                    {
                        var id = (int)((Button)s).Tag;
                        var confirm = MessageBox.Show("Hapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirm == DialogResult.Yes)
                        {
                            _produkController.DeleteProduk(id);
                            LoadProduk();
                        }
                    };

                    // Add controls to panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(lblNamaValue);
                    panel.Controls.Add(lblStokHeading);
                    panel.Controls.Add(lblStokValue);
                    panel.Controls.Add(lblTglHeading);
                    panel.Controls.Add(lblTglValue);
                    panel.Controls.Add(lblKdlHeading);
                    panel.Controls.Add(lblKdlValue);
                    panel.Controls.Add(lblHargaHeading);
                    panel.Controls.Add(lblHargaValue);
                    panel.Controls.Add(btnEdit);
                    panel.Controls.Add(btnDelete);

                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembaliDB_Click(object sender, EventArgs e)
        {
            V_BerandaAdmin berandaAdmin = new V_BerandaAdmin();
            berandaAdmin.FormClosed += (s, args) => this.Close();
            berandaAdmin.Show();
            this.Hide();
        }
    }

}
