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
    public partial class ProdukCard : UserControl
    {
        public event EventHandler<int> OnQtyChanged;

        public int IdProduk { get; private set; }
        public int Harga { get; private set; }
        public int StokMaks { get; private set; }
        public string NamaProduk { get; private set; }

        private int _currentQty = 0;

        private ToolTip _infoTooltip = new ToolTip();
        public ProdukCard()
        {
            InitializeComponent();
        }

        public void SetData(int id, string nama, int harga, int stok, string satuan,
                            string deskripsi, string lokasi, byte[] gambarBytes)
        {
            IdProduk = id;
            Harga = harga;
            StokMaks = stok;
            NamaProduk = nama;

            lblNama.Text = nama;
            lblHarga.Text = "Rp " + harga.ToString("N0"); 
            lblStok.Text = $"Stok: {stok} {satuan}"; 
            
            if (gambarBytes != null && gambarBytes.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(gambarBytes))
                    {
                        pbGambar.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    pbGambar.Image = null;
                }
            }
            else
            {
                pbGambar.Image = null;
            }

            string infoLengkap = $"Deskripsi: {deskripsi}\nLokasi Rak: {lokasi}";
            _infoTooltip.SetToolTip(pbGambar, infoLengkap);
            _infoTooltip.SetToolTip(lblNama, infoLengkap);

            _currentQty = 0;
            UpdateUI();
        }
        private void ProdukCard_Load(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (_currentQty < StokMaks)
            {
                _currentQty++;
                UpdateUI();
                OnQtyChanged?.Invoke(this, _currentQty);
            }
            else
            {
                MessageBox.Show("Stok tidak mencukupi!");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_currentQty > 0)
            {
                _currentQty--;
                UpdateUI();
                OnQtyChanged?.Invoke(this, _currentQty);
            }
        }

        private void UpdateUI()
        {
            lblQty.Text = _currentQty.ToString();

            if (_currentQty > 0)
            {
                //this.BackColor = Color.FromArgb(235, 255, 235); // Hijau sangat muda
            }
            else
            {
                //this.BackColor = Color.White;
            }
        }
        public void SetJumlah(int qty)
        {
            _currentQty = qty;
            UpdateUI(); 
        }
    }
}
