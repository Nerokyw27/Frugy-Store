using Frugy_Store.Controller;
using Frugy_Store.Model;
using Npgsql;
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
    public partial class V_TransaksiKasir : Form
    {
        private C_Produk _prodController;
        private C_Transaksi _transController;
        private int _idKasir;

        private Dictionary<int, M_DetailTransaksi> _keranjang = new Dictionary<int, M_DetailTransaksi>();
        public V_TransaksiKasir(int idKasir)
        {
            InitializeComponent();
            _idKasir = idKasir;
            MessageBox.Show("ID Kasir: " + _idKasir);
            _prodController = new C_Produk();
            _transController = new C_Transaksi();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            LoadProdukCards("");
        }

        void LoadProdukCards(string keyword)
        {
            flowPanelProduk.Controls.Clear();

            List<M_Produk> listProduk = _prodController.GetProduk();

            foreach (var item in listProduk)
            {
                if (!string.IsNullOrEmpty(keyword) &&
                    !item.NamaProduk.ToLower().Contains(keyword.ToLower()))
                {
                    continue;
                }
                int id = item.IdProduk;

                ProdukCard card = new ProdukCard();
                card.SetData(
                item.IdProduk,
                item.NamaProduk,
                item.Harga,
                item.Stok,
                item.Satuan ?? "",
                item.Deskripsi ?? "",
                item.Lokasi ?? "",
                item.Image
                );

                card.Margin = new Padding(10);

                if (_keranjang.ContainsKey(id))
                {
                    int qtyDiKeranjang = _keranjang[item.IdProduk].Kuantitas;

                    card.SetJumlah(qtyDiKeranjang);
                }

                card.OnQtyChanged += (sender, qtyBaru) =>
                {
                    UpdateIsiKeranjang(item.IdProduk, item.NamaProduk, item.Harga, qtyBaru);
                };

                flowPanelProduk.Controls.Add(card);
            }
        }

        void UpdateIsiKeranjang(int idProduk, string nama, int harga, int qty)
        {
            if (qty > 0)
            {
                if (_keranjang.ContainsKey(idProduk))
                {
                    _keranjang[idProduk].Kuantitas = qty;
                }
                else
                {
                    _keranjang.Add(idProduk, new M_DetailTransaksi
                    {
                        IdProduk = idProduk,
                        NamaProduk = nama,
                        Harga = harga,
                        Kuantitas = qty
                    });
                }
            }
            else
            {
                if (_keranjang.ContainsKey(idProduk))
                {
                    _keranjang.Remove(idProduk);
                }
            }

            RefreshTampilanKanan();
            HitungTotal();
        }
        void RefreshTampilanKanan()
        {
            flowKeranjang.Controls.Clear();

            foreach (var item in _keranjang.Values)
            {
                ItemKeranjang itemUI = new ItemKeranjang();

                itemUI.SetData(item.IdProduk, item.NamaProduk, item.Kuantitas, item.Subtotal);

                itemUI.Margin = new Padding(0, 5, 0, 5);

                itemUI.OnHapusClicked += (s, e) =>
                {
                    _keranjang.Remove(item.IdProduk);

                    RefreshTampilanKanan();
                    HitungTotal();

                    LoadProdukCards(txtCari.Text);
                };

                flowKeranjang.Controls.Add(itemUI);
            }
        }
        void HitungTotal()
        {
            int total = _keranjang.Values.Sum(x => x.Subtotal);
            lblTotalBayar.Text = "Rp " + total.ToString("N0");
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            LoadProdukCards(txtCari.Text);
        }

        private void V_TransaksiKasir_Load(object sender, EventArgs e)
        {

        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if (_keranjang.Count == 0) { MessageBox.Show("Keranjang Kosong!"); return; }

            int total = _keranjang.Values.Sum(x => x.Subtotal);
            var listBelanja = _keranjang.Values.ToList();

            FormPembayaran formBayar = new FormPembayaran(listBelanja, total);
            formBayar.ShowDialog();

            if (formBayar.IsPembayaranSukses)
            {
                M_Transaksi transBaru = new M_Transaksi
                {
                    AkunId = _idKasir,
                    MetodePembayaran = formBayar.MetodePembayaran,
                    ListDetail = listBelanja
                };

                try
                {
                    if (_transController.SimpanTransaksi(transBaru))
                    {
                        MessageBox.Show("Transaksi Selesai!");
                        _keranjang.Clear();
                        LoadProdukCards("");
                        RefreshTampilanKanan();
                        lblTotalBayar.Text = "Total: Rp 0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            V_BerandaKasir berandaKasir = new V_BerandaKasir(_idKasir);
            berandaKasir.FormClosed += (s, args) => this.Close();
            berandaKasir.Show();
            this.Hide();
        }
    }
}
