using Frugy_Store.Controller;
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
    public partial class V_Kasir : Form
    {
        private C_Kasir cKasir = new C_Kasir();
        private AuthController _akunController;
        public V_Kasir()
        {
            InitializeComponent();
            LoadKasirPanels();
            _akunController = new AuthController();
            this.WindowState = FormWindowState.Maximized;
            // Event tanpa lambda dan tanpa double click
            //PanelTambahKasir.Click += PanelTambahKasir_Click;
        }

        // Event klik tombol
        private void PanelTambahKasir_Click(object sender, EventArgs e)
        {

            V_TambahKasir formTambah = new V_TambahKasir();
            formTambah.ShowDialog();
            LoadKasirPanels();
        }

        private void LoadKasirPanels()
        {
            PanelContainerKasir.Controls.Clear();

            List<M_Kasir> listKasir = cKasir.GetAllKasir();

            int posY = 10;

            foreach (var kasir in listKasir)
            {
                Panel panelKasir = new Panel();
                panelKasir.Size = new Size(300, 70);
                panelKasir.BackColor = Color.LightGreen;
                panelKasir.Location = new Point(10, posY);
                panelKasir.Cursor = Cursors.Hand;
                panelKasir.Tag = kasir;  // Simpan data kasir

                // ==== Label Nama ====
                Label lblNama = new Label();
                lblNama.Text = kasir.NamaLengkap;
                lblNama.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                lblNama.Location = new Point(15, 10);
                lblNama.AutoSize = true;
                lblNama.Cursor = Cursors.Hand;

                // ==== Label Username ====
                Label lblUser = new Label();
                lblUser.Text = "Username: " + kasir.Username;
                lblUser.Font = new Font("Segoe UI", 9);
                lblUser.Location = new Point(15, 40);
                lblUser.AutoSize = true;
                lblUser.Cursor = Cursors.Hand;

                //Add ke panel
                panelKasir.Controls.Add(lblNama);
                panelKasir.Controls.Add(lblUser);

                // Event klik
                panelKasir.Click += PanelKasir_Click;
                lblNama.Click += PanelKasir_Click;
                lblUser.Click += PanelKasir_Click;

                PanelContainerKasir.Controls.Add(panelKasir);

                posY += 80;
            }
        }

        // ========== KLIK SALAH SATU KASIR ==========
        private void PanelKasir_Click(object sender, EventArgs e)
        {
            // Ambil panel-nya
            Control ctrl = sender as Control;
            Panel panel = ctrl is Panel ? (Panel)ctrl : (Panel)ctrl.Parent;

            // Ambil data kasir dari Tag
            M_Kasir kasir = (M_Kasir)panel.Tag;

            // Buka form detail/edit
            V_FormEditKasir f = new V_FormEditKasir(kasir);
            f.Show();
        }


        private void V_TambahKasir_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void V_Kasir_Load(object sender, EventArgs e)
        {
            LoadKasirPanels();
        }

        private void LBKasir1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBStatus1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTambahKasir_Click(object sender, EventArgs e)
        {
            V_TambahKasir formTambah = new V_TambahKasir();
            formTambah.ShowDialog();
            LoadKasirPanels();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
