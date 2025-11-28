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
    public partial class ItemKeranjang : UserControl
    {
        public event EventHandler OnHapusClicked;

        public int IdProduk
        {
            get; private set;
        }
        public ItemKeranjang()
        {
            InitializeComponent();
        }
        public void SetData(int id, string nama, int qty, int subtotal)
        {
            IdProduk = id;
            lblNama.Text = nama;
            lblDetail.Text = $"{qty}x  =  Rp {subtotal:N0}";
        }

        private void ItemKeranjang_Load(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            OnHapusClicked?.Invoke(this, e);
        }
    }
}
