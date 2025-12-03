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

namespace Frugy_Store.Views.View_Admin
{
    public partial class V_LaporanAdm : Form
    {
        private C_Laporan _controller;
        public V_LaporanAdm()
        {
            InitializeComponent();
            _controller = new C_Laporan();
            this.WindowState = FormWindowState.Maximized;

            SetupComboBox();

            dtpMulai.Value = DateTime.Now;
            dtpSelesai.Value = DateTime.Now;

            SetupGrid(dgvPenjualan);
            SetupGrid(dgvStok);
        }
        void SetupComboBox()
        {
            cbJenisLaporan.Items.Clear();
            cbJenisLaporan.Items.Add("Riwayat Penjualan"); // Index 0
            cbJenisLaporan.Items.Add("Laporan Stok");      // Index 1

            // Default pilih Penjualan
            cbJenisLaporan.SelectedIndex = 0;
        }
        void SetupGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
        }


        void LoadPenjualan()
        {
            try
            {
                DataTable dt = _controller.GetLaporanPenjualan(dtpMulai.Value, dtpSelesai.Value);
                dgvPenjualan.DataSource = dt;

                // Hitung Total Omset
                long total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Total Belanja"] != DBNull.Value)
                        total += Convert.ToInt64(row["Total Belanja"]);
                }
                lblOmset.Text = "Total Omset: Rp " + total.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void LoadStok()
        {
            try
            {
                dgvStok.DataSource = _controller.GetLaporanStok();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvStok_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Pastikan nama kolom sesuai query di Controller ("Sisa Stok")
            if (dgvStok.Columns[e.ColumnIndex].Name == "Sisa Stok" && e.Value != null)
            {
                int stok = Convert.ToInt32(e.Value);

                if (stok <= 5)
                {
                    // BARIS JADI MERAH (KRITIS)
                    dgvStok.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
                    dgvStok.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                    dgvStok.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
                    dgvStok.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
                else if (stok <= 20)
                {
                    // BARIS JADI KUNING (MENIPIS)
                    dgvStok.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                }
            }

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            LoadPenjualan();
        }

        private void cbJenisLaporan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbJenisLaporan.SelectedIndex == 0)
            {
                dgvPenjualan.Visible = true;
                dgvStok.Visible = false;

                LoadPenjualan();
            }
            else
            {
                dgvPenjualan.Visible = false;
                dgvStok.Visible = true;

                LoadStok();
            }
        }

        private void dgvStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dgvStok.Rows[e.RowIndex];
            //    if (stok <= 5)
            //    {
            //        dgvStok.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            //        dgvStok.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            //    }
            //    else if (stok <= 20)
            //    {
            //        dgvStok.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            //    }
            //}
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }
    }
}
