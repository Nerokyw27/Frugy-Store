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
                string lokasi = tbLokasi.Text;
                string deskripsi = tbDeskripsi.Text;
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
                    Lokasi = lokasi,
                    Deskripsi = deskripsi,
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin membatalkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
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

        private void tbNamaBuahSayur_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            V_TampilanProduk tampilanProduk = new V_TampilanProduk();
            tampilanProduk.FormClosed += (s, args) => this.Close();
            tampilanProduk.Show();
            this.Hide();
        }
    }
}
