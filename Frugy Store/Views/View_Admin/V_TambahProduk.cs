using Frugy_Store.Controller;
using Frugy_Store.Database;
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
    public partial class V_TambahProduk : Form
    {
        public V_TambahProduk()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(dialog.FileName); // tampilkan ke PictureBox

                    byte[] imgBytes = File.ReadAllBytes(dialog.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect data from input fields
                string namaProduk = tbNamaBuahSayur.Text;
                DateTime tglMasuk = DateTime.Parse(tbTglMasuk.Text);
                DateTime kadaluarsa = DateTime.Parse(tbKadaluarsa.Text);
                int stok = int.Parse(tbStokBrg.Text);
                int harga = int.Parse(tbHarga.Text);
                string satuan = tbSatuan.Text;

                // Convert image to byte array
                byte[] imageBytes = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                // Create product object
                M_Produk product = new M_Produk
                {
                    NamaProduk = namaProduk,
                    TanggalMasuk = tglMasuk,
                    Kadaluarsa = kadaluarsa,
                    Stok = stok,
                    Harga = harga,
                    Satuan = satuan,
                    Image = imageBytes,
                    IdJenisProduk = idJenisProduk
                };

                // Save to database
                C_Produk c_Produk = new C_Produk();
                c_Produk.TambahProduk(product);

                MessageBox.Show("Produk berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error menyimpan produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int idJenisProduk;
        private void cbSayur_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSayur.Checked)
            {
                idJenisProduk = 1;
                cbBuah.Checked = false;
            }
        }

        private void cbBuah_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBuah.Checked)
            {
                idJenisProduk = 2;
                cbSayur.Checked = false;
            }
        }
    }
}
