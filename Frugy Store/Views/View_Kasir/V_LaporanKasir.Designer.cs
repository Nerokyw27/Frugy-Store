namespace Frugy_Store.Views.View_Kasir
{
    partial class V_LaporanKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LaporanKasir));
            lblNamaKasir = new Label();
            dtpMulai = new DateTimePicker();
            dtpSelesai = new DateTimePicker();
            label1 = new Label();
            lblTotalOmset = new Label();
            dgvRiwayat = new DataGridView();
            btnFilter = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // lblNamaKasir
            // 
            lblNamaKasir.AutoSize = true;
            lblNamaKasir.BackColor = Color.Transparent;
            lblNamaKasir.FlatStyle = FlatStyle.Flat;
            lblNamaKasir.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaKasir.Location = new Point(1550, 156);
            lblNamaKasir.Name = "lblNamaKasir";
            lblNamaKasir.Size = new Size(156, 37);
            lblNamaKasir.TabIndex = 0;
            lblNamaKasir.Text = "nama kasir";
            // 
            // dtpMulai
            // 
            dtpMulai.Location = new Point(1550, 332);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(247, 23);
            dtpMulai.TabIndex = 1;
            // 
            // dtpSelesai
            // 
            dtpSelesai.Location = new Point(1550, 424);
            dtpSelesai.Name = "dtpSelesai";
            dtpSelesai.Size = new Size(247, 23);
            dtpSelesai.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1667, 379);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 3;
            label1.Text = "s/d";
            // 
            // lblTotalOmset
            // 
            lblTotalOmset.AutoSize = true;
            lblTotalOmset.BackColor = Color.Transparent;
            lblTotalOmset.FlatStyle = FlatStyle.Flat;
            lblTotalOmset.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOmset.Location = new Point(1550, 234);
            lblTotalOmset.Name = "lblTotalOmset";
            lblTotalOmset.Size = new Size(184, 40);
            lblTotalOmset.TabIndex = 4;
            lblTotalOmset.Text = "Omset: Rp 0";
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.BackgroundColor = Color.Honeydew;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(410, 143);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.Size = new Size(958, 877);
            dgvRiwayat.TabIndex = 5;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Image = (Image)resources.GetObject("btnFilter.Image");
            btnFilter.Location = new Point(1534, 496);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(282, 58);
            btnFilter.TabIndex = 6;
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(339, 12);
            button1.Name = "button1";
            button1.Size = new Size(282, 58);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // V_LaporanKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(btnFilter);
            Controls.Add(dgvRiwayat);
            Controls.Add(lblTotalOmset);
            Controls.Add(label1);
            Controls.Add(dtpSelesai);
            Controls.Add(dtpMulai);
            Controls.Add(lblNamaKasir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_LaporanKasir";
            Text = "V_LaporanKasir";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaKasir;
        private DateTimePicker dtpMulai;
        private DateTimePicker dtpSelesai;
        private Label label1;
        private Label lblTotalOmset;
        private DataGridView dgvRiwayat;
        private Button btnFilter;
        private Button button1;
    }
}