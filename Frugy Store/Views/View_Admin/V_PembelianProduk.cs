using Frugy_Store.Controller;
using Frugy_Store.Model;
using Frugy_Store.Views.View_Kasir;
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
    public partial class V_PembelianProduk : Form
    {
        private C_Produk _prodController;
        private C_Pembelian _beliController;

        private Dictionary<int, M_DetailPembelian> _keranjang = new Dictionary<int, M_DetailPembelian>();

        public V_PembelianProduk()
        {
            InitializeComponent();
            _prodController = new C_Produk();
            _beliController = new C_Pembelian();

            this.WindowState = FormWindowState.Maximized; // Full Screen Admin

            LoadProdukCards("");
        }
        void LoadProdukCards(string keyword)
        {
            flowPanelProduk.Controls.Clear();
            var listProduk = _prodController.GetProduk();

            foreach (var item in listProduk)
            {
                // Filter Pencarian
                if (!string.IsNullOrEmpty(keyword) && !item.NamaProduk.ToLower().Contains(keyword.ToLower())) continue;

                ProdukCard card = new ProdukCard();

                card.SetData(
                    item.IdProduk,
                    item.NamaProduk,
                    item.Harga,
                    int.MaxValue,
                    item.Satuan ?? "",
                    item.Deskripsi ?? "",
                    item.Lokasi ?? "",
                    item.Image
                );

                if (card.Controls["lblStok"] != null)
                    card.Controls["lblStok"].Text = $"Stok Saat Ini: {item.Stok} {item.Satuan}";

                card.Margin = new Padding(10);

                if (_keranjang.ContainsKey(item.IdProduk))
                    card.SetJumlah(_keranjang[item.IdProduk].KuantitasStok);
                else
                    card.SetJumlah(0);

                card.OnQtyChanged += (sender, qtyBaru) =>
                {
                    UpdateKeranjang(item.IdProduk, item.NamaProduk, qtyBaru);
                };

                flowPanelProduk.Controls.Add(card);
            }
        }

        void UpdateKeranjang(int id, string nama, int qty)
        {
            if (qty > 0)
            {
                if (_keranjang.ContainsKey(id))
                {
                    _keranjang[id].KuantitasStok = qty;
                }
                else
                {
                    _keranjang.Add(id, new M_DetailPembelian
                    {
                        IdProduk = id,
                        NamaProduk = nama, // Helper buat UI
                        KuantitasStok = qty
                    });
                }
            }
            else
            {
                if (_keranjang.ContainsKey(id)) _keranjang.Remove(id);
            }

            RefreshTampilanKanan();
        }

        void RefreshTampilanKanan()
        {
            flowPanelKeranjang.Controls.Clear();
            int totalItem = 0;

            foreach (var item in _keranjang.Values)
            {
                ItemKeranjang itemUI = new ItemKeranjang();
                itemUI.SetData(item.IdProduk, item.NamaProduk, item.KuantitasStok, 0);
                if (itemUI.Controls["lblDetail"] != null)
                    itemUI.Controls["lblDetail"].Text = $"Masuk: {item.KuantitasStok} Pcs";

                itemUI.Margin = new Padding(0, 5, 0, 5);

                // Event Hapus
                itemUI.OnHapusClicked += (s, e) =>
                {
                    _keranjang.Remove(item.IdProduk);
                    RefreshTampilanKanan();
                    LoadProdukCards(txtCari.Text); // Reset kartu kiri
                };

                flowPanelKeranjang.Controls.Add(itemUI);
                totalItem += item.KuantitasStok;
            }

            // Update Info Total
            lblTotalItem.Text = $"Total Barang: {totalItem}";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_keranjang.Count == 0)
            {
                MessageBox.Show("Pilih barang yang akan direstock dulu!", "Info");
                return;
            }
            List<M_DetailPembelian> listRestock = _keranjang.Values.ToList();

            FormPembelian formKonfirmasi = new FormPembelian(listRestock);
            formKonfirmasi.ShowDialog();

            if (formKonfirmasi.IsSukses)
            {
                try
                {
                    // Ambil Nama Supplier yang barusan diketik Admin
                    string supplier = formKonfirmasi.NamaSupplierOutput;

                    // Bungkus jadi object M_Pembelian
                    M_Pembelian dataRestock = new M_Pembelian
                    {
                        Supplier = supplier,
                        ListBarangMasuk = listRestock
                    };

                    // Panggil Controller buat simpan ke Database
                    if (_beliController.SimpanRestock(dataRestock))
                    {
                        MessageBox.Show("Stok Berhasil Ditambahkan!", "Sukses");

                        // Bersih-bersih
                        _keranjang.Clear();
                        RefreshTampilanKanan(); // Kosongkan keranjang kanan
                        LoadProdukCards("");    // Reload kartu kiri (stok otomatis nambah)
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal: " + ex.Message);
                }
            }
        }

        private void flowPanelProduk_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
