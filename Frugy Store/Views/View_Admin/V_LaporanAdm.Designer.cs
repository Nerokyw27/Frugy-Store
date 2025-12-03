namespace Frugy_Store.Views.View_Admin
{
    partial class V_LaporanAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LaporanAdm));
            btnKembali = new Button();
            lblJudul = new Label();
            cbJenisLaporan = new ComboBox();
            dtpMulai = new DateTimePicker();
            lbl = new Label();
            dtpSelesai = new DateTimePicker();
            btnTampilkan = new Button();
            lblOmset = new Label();
            dgvPenjualan = new DataGridView();
            dgvStok = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Image = (Image)resources.GetObject("btnKembali.Image");
            btnKembali.Location = new Point(323, -1);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(345, 80);
            btnKembali.TabIndex = 0;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.Transparent;
            lblJudul.FlatStyle = FlatStyle.Flat;
            lblJudul.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(1617, 176);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(130, 40);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Laporan";
            lblJudul.Click += lblJudul_Click;
            // 
            // cbJenisLaporan
            // 
            cbJenisLaporan.BackColor = Color.Honeydew;
            cbJenisLaporan.FlatStyle = FlatStyle.Flat;
            cbJenisLaporan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbJenisLaporan.FormattingEnabled = true;
            cbJenisLaporan.Items.AddRange(new object[] { "Riwayat Penjualan", "Stok" });
            cbJenisLaporan.Location = new Point(1617, 231);
            cbJenisLaporan.Name = "cbJenisLaporan";
            cbJenisLaporan.Size = new Size(260, 29);
            cbJenisLaporan.TabIndex = 2;
            cbJenisLaporan.SelectedIndexChanged += cbJenisLaporan_SelectedIndexChanged_1;
            // 
            // dtpMulai
            // 
            dtpMulai.Location = new Point(1617, 387);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(260, 23);
            dtpMulai.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.FlatStyle = FlatStyle.Flat;
            lbl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(1732, 423);
            lbl.Name = "lbl";
            lbl.Size = new Size(30, 20);
            lbl.TabIndex = 1;
            lbl.Text = "s/d";
            // 
            // dtpSelesai
            // 
            dtpSelesai.Location = new Point(1617, 460);
            dtpSelesai.Name = "dtpSelesai";
            dtpSelesai.Size = new Size(260, 23);
            dtpSelesai.TabIndex = 4;
            // 
            // btnTampilkan
            // 
            btnTampilkan.BackColor = Color.Transparent;
            btnTampilkan.FlatAppearance.BorderSize = 0;
            btnTampilkan.FlatStyle = FlatStyle.Flat;
            btnTampilkan.Image = (Image)resources.GetObject("btnTampilkan.Image");
            btnTampilkan.Location = new Point(1589, 516);
            btnTampilkan.Name = "btnTampilkan";
            btnTampilkan.Size = new Size(303, 78);
            btnTampilkan.TabIndex = 5;
            btnTampilkan.UseVisualStyleBackColor = false;
            btnTampilkan.Click += btnTampilkan_Click;
            // 
            // lblOmset
            // 
            lblOmset.AutoSize = true;
            lblOmset.BackColor = Color.Transparent;
            lblOmset.FlatStyle = FlatStyle.Flat;
            lblOmset.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOmset.Location = new Point(1617, 309);
            lblOmset.Name = "lblOmset";
            lblOmset.Size = new Size(158, 25);
            lblOmset.TabIndex = 6;
            lblOmset.Text = "Total Omset Rp 0";
            // 
            // dgvPenjualan
            // 
            dgvPenjualan.BackgroundColor = Color.Honeydew;
            dgvPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualan.Location = new Point(375, 161);
            dgvPenjualan.Name = "dgvPenjualan";
            dgvPenjualan.Size = new Size(1112, 845);
            dgvPenjualan.TabIndex = 7;
            // 
            // dgvStok
            // 
            dgvStok.BackgroundColor = Color.Honeydew;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStok.Location = new Point(375, 161);
            dgvStok.Name = "dgvStok";
            dgvStok.Size = new Size(1112, 845);
            dgvStok.TabIndex = 8;
            dgvStok.Visible = false;
            dgvStok.CellContentClick += dgvStok_CellContentClick;
            // 
            // V_LaporanAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblOmset);
            Controls.Add(btnTampilkan);
            Controls.Add(lbl);
            Controls.Add(dtpSelesai);
            Controls.Add(dtpMulai);
            Controls.Add(cbJenisLaporan);
            Controls.Add(lblJudul);
            Controls.Add(btnKembali);
            Controls.Add(dgvStok);
            Controls.Add(dgvPenjualan);
            Name = "V_LaporanAdm";
            Text = "V_LaporanAdm";
            ((System.ComponentModel.ISupportInitialize)dgvPenjualan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKembali;
        private Label lblJudul;
        private ComboBox cbJenisLaporan;
        private DateTimePicker dtpMulai;
        private Label lbl;
        private DateTimePicker dtpSelesai;
        private Button btnTampilkan;
        private Label lblOmset;
        private DataGridView dgvPenjualan;
        private DataGridView dgvStok;
    }
}