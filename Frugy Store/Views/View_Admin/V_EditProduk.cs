using Frugy_Store.Controller;
using Frugy_Store.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Frugy_Store.Views.View_Admin
{
    public partial class V_EditProduk : Form
    {
        private readonly int _idProduk;
        private readonly C_Produk _produkController;
        private M_Produk _produk;

        public V_EditProduk(int idProduk)
        {
            InitializeComponent();
            _idProduk = idProduk;
            _produkController = new C_Produk();
            Load += V_EditProduk_Load;

            btnUploadEP.Click += BtnUploadEP_Click;
            btnSimpanEP.Click += BtnSimpanEP_Click;
            btnBatalEP.Click += BtnBatalEP_Click;
            btnKembaliEP.Click += BtnKembaliEP_Click;
        }

        private void V_EditProduk_Load(object sender, EventArgs e)
        {
            try
            {
                _produk = _produkController.GetProdukById(_idProduk);
                if (_produk == null)
                {
                    MessageBox.Show("Produk tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                // isi control dengan data produk
                tbNamaProdukEP.Text = _produk.NamaProduk;
                tbHargaEP.Text = _produk.Harga.ToString();
                tbSatuanEP.Text = _produk.Satuan;
                tbLokasiEP.Text = _produk.Lokasi;
                tbDeskripsiEP.Text = _produk.Deskripsi;

                if (_produk.Image != null && _produk.Image.Length > 0)
                {
                    try
                    {
                        using var ms = new MemoryStream(_produk.Image);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void BtnUploadEP_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void BtnSimpanEP_Click(object sender, EventArgs e)
        {
            try
            {
                _produk.NamaProduk = tbNamaProdukEP.Text;
                _produk.Harga = int.TryParse(tbHargaEP.Text, out var h) ? h : 0;
                _produk.Satuan = tbSatuanEP.Text;
                _produk.Lokasi = tbLokasiEP.Text;
                _produk.Deskripsi = tbDeskripsiEP.Text;

                if (pictureBox1.Image != null)
                {
                    using MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    _produk.Image = ms.ToArray();
                }

                bool ok = _produkController.UpdateProduk(_produk);
                if (ok)
                {
                    MessageBox.Show("Perubahan produk tersimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnBatalEP_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Batalkan perubahan? Semua perubahan yang belum disimpan akan hilang.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void BtnKembaliEP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
