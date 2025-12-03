using Frugy_Store.Model;
using Frugy_Store.Views.View_Kasir;
using System;
using System.Collections;
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
    public partial class FormPembelian : Form
    {
        private List<M_DetailPembelian> _listRestock;

        public string NamaSupplierOutput { get; private set; } = "";
        public bool IsSukses { get; private set; } = false;
        public FormPembelian(List<M_DetailPembelian> listBarang)
        {
            InitializeComponent();
            _listRestock = listBarang;

            // Tampilan Full Screen agar fokus
            this.WindowState = FormWindowState.Maximized;

            // Langsung arahkan kursor ke input supplier
            this.ActiveControl = txtSupplier;

            HitungTotal();
            LoadSummary();
        }

        void HitungTotal()
        {
            int totalQty = 0;
            foreach (var item in _listRestock)
            {
                totalQty += item.KuantitasStok;
            }
            lblTotalItem.Text = $"Total Barang Masuk: {totalQty} Pcs";
        }

        void LoadSummary()
        {
            flowSummary.Controls.Clear();

            foreach (var item in _listRestock)
            {
                // RE-USE (Pakai Lagi) UC_ItemKeranjang yang sudah kamu buat
                ItemKeranjang kartu = new ItemKeranjang();

                // Set Data:
                // - Harga & Subtotal kita isi 0 karena ini Restock stok (bukan uang)
                kartu.SetData(item.IdProduk, item.NamaProduk, item.KuantitasStok, 0);

                // Trik: Ubah label detail secara manual agar tidak menampilkan "Rp 0"
                // (Pastikan Modifiers label di UC_ItemKeranjang diset Public, atau gunakan Controls search)
                if (kartu.Controls["lblDetail"] != null)
                {
                    kartu.Controls["lblDetail"].Text = $"Masuk: {item.KuantitasStok} Pcs";
                }

                // Matikan fitur hapus di form konfirmasi ini (biar cuma review)
                kartu.Enabled = false;

                // Atur jarak antar kartu
                kartu.Margin = new Padding(5);

                flowSummary.Controls.Add(kartu);
            }
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show("Nama Supplier Wajib Diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplier.Focus();
                return;
            }

            // Simpan data ke properti publik
            NamaSupplierOutput = txtSupplier.Text;
            IsSukses = true; // Tandai berhasil

            this.Close(); // Tutup form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsSukses = false; // Tandai batal
            this.Close();
        }
    }
}
