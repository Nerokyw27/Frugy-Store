using Frugy_Store.Controller;
using Frugy_Store.Interface;
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
    public partial class V_TambahKasir : Form
    {
        private OpenFileDialog openFileDialog;
        private IProduk productController;
        public V_TambahKasir()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            productController = new C_Produk();
        }

        private void V_TambahKasir_Load(object sender, EventArgs e)
        {

        }
    }
}
  