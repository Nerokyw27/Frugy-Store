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

namespace Frugy_Store.Views.View_Kasir
{
    public partial class FormPembayaran : Form
    {
        private List<M_DetailTransaksi> _listBelanja;
        private int _totalTagihan;

        public bool IsPembayaranSukses { get; private set; } = false;
        public string MetodePembayaran { get; private set; } = "";
        public FormPembayaran(List<M_DetailTransaksi> listBelanja, int total)
        {
            InitializeComponent();
            _listBelanja = listBelanja;
            _totalTagihan = total;

            lblTotalBayar.Text = "Rp " + _totalTagihan.ToString("N0");
            lblKembalian.Text = "Kembalian: Rp 0";

            rbCash.Checked = true;
            btnBayar.Enabled = false;

            LoadSummaryProduk();

            this.ActiveControl = txtUangMasuk;
        }

        void LoadSummaryProduk()
        {
            flowSummary.Controls.Clear();

            foreach (var item in _listBelanja)
            {
                ItemKeranjang kartu = new ItemKeranjang();

                kartu.SetData(item.IdProduk, item.NamaProduk, item.Kuantitas, item.Subtotal);

                kartu.Enabled = false;
                kartu.Margin = new Padding(5);

                flowSummary.Controls.Add(kartu);
            }
        }


        private void FormPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCash.Checked)
            {
                txtUangMasuk.Text = "";
                txtUangMasuk.Enabled = true;
                txtUangMasuk.Focus();

                lblKembalian.Text = "Kembalian: Rp 0";
                lblKembalian.ForeColor = Color.Black;

                btnBayar.Enabled = false;
            }
        }

        private void rbQR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQR.Checked)
            {
                txtUangMasuk.Text = _totalTagihan.ToString("N0");
                txtUangMasuk.Enabled = false; 

                lblKembalian.Text = "Kembalian: Rp 0 (Lunas)";
                lblKembalian.ForeColor = Color.Blue;

                btnBayar.Enabled = true;
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            IsPembayaranSukses = true;
            MetodePembayaran = rbCash.Checked ? "Tunai" : "QRIS";

            this.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            IsPembayaranSukses = false;
            this.Close();
        }

        private void lblKembalian_Click(object sender, EventArgs e)
        {
            if (rbQR.Checked) return;

            try
            {
                if (string.IsNullOrEmpty(txtUangMasuk.Text))
                {
                    lblKembalian.Text = "Kembalian: Rp 0";
                    btnBayar.Enabled = false;
                    return;
                }

                string cleanAngka = txtUangMasuk.Text.Replace(".", "").Replace(",", "").Replace("Rp", "").Trim();

                if (cleanAngka.Length > 9) return;

                int uangMasuk = int.Parse(cleanAngka);
                int kembali = uangMasuk - _totalTagihan;

                if (kembali >= 0)
                {
                    lblKembalian.Text = "Kembalian: Rp " + kembali.ToString("N0");
                    lblKembalian.ForeColor = Color.DarkGreen; 
                    btnBayar.Enabled = true; 
                }
                else
                {
                    lblKembalian.Text = "Kurang: Rp " + Math.Abs(kembali).ToString("N0");
                    lblKembalian.ForeColor = Color.Red;
                    btnBayar.Enabled = false; 
                }
            }
            catch
            {
            }
        }

        private void lblKembalian_TextChanged(object sender, EventArgs e)
        {
            if (rbQR.Checked) return;

            try
            {
                if (string.IsNullOrEmpty(txtUangMasuk.Text))
                {
                    lblKembalian.Text = "Kembalian: Rp 0";
                    btnBayar.Enabled = false; 
                    return;
                }

                string inputBersih = txtUangMasuk.Text
                    .Replace(".", "")
                    .Replace(",", "")
                    .Replace("Rp", "")
                    .Replace(" ", "")
                    .Trim();

                long uangMasuk = 0;
                if (!long.TryParse(inputBersih, out uangMasuk)) return; 

                long kembali = uangMasuk - _totalTagihan;

                if (kembali >= 0)
                {
                    lblKembalian.Text = "Kembalian: Rp " + kembali.ToString("N0");
                    lblKembalian.ForeColor = Color.Black;
                    btnBayar.Enabled = true; 
                }
                else
                {
                    lblKembalian.Text = "Kurang: Rp " + Math.Abs(kembali).ToString("N0");
                    lblKembalian.ForeColor = Color.Red;

                    btnBayar.Enabled = false;
                }
            }
            catch
            {

            }
        }
    }
}
