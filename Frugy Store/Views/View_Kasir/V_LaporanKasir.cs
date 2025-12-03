using Frugy_Store.Controller;
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
    public partial class V_LaporanKasir : Form
    {
        private C_Laporan _controller;
        private int _idKasirTarget;
        public V_LaporanKasir(int idKasir, string namaKasir)
        {
            InitializeComponent();
            _controller = new C_Laporan();
            _idKasirTarget = idKasir;

            // Setup UI
            this.Text = $"Laporan - {namaKasir}";
            lblNamaKasir.Text = $"Riwayat Transaksi: {namaKasir}";

            dtpMulai.Value = DateTime.Now;
            dtpSelesai.Value = DateTime.Now;

            SetupGrid();
            LoadData();
        }
        void SetupGrid()
        {
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersVisible = false;
            dgvRiwayat.AllowUserToAddRows = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            try
            {
                // Panggil Controller dengan ID Kasir
                DataTable dt = _controller.GetTransaksiByKasir(_idKasirTarget, dtpMulai.Value, dtpSelesai.Value);
                dgvRiwayat.DataSource = dt;

                // Hitung Total Omset Kasir Ini
                long total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Total Belanja"] != DBNull.Value)
                        total += Convert.ToInt64(row["Total Belanja"]);
                }
                lblTotalOmset.Text = "Total Omset: Rp " + total.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
