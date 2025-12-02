namespace Frugy_Store.Views.View_Admin
{
    partial class V_ManajemenKasir
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnEditKasir = new Button();
            isiEmail = new Label();
            btnHapusKasir = new Button();
            isiNoHP = new Label();
            lblNoHP = new Label();
            lblEmail = new Label();
            lblNamaKasir = new Label();
            btnTambahKasir = new Button();
            btnKembaliMK = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(405, 205);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1435, 763);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnEditKasir);
            panel1.Controls.Add(isiEmail);
            panel1.Controls.Add(btnHapusKasir);
            panel1.Controls.Add(isiNoHP);
            panel1.Controls.Add(lblNoHP);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNamaKasir);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 279);
            panel1.TabIndex = 0;
            // 
            // btnEditKasir
            // 
            btnEditKasir.Location = new Point(254, 225);
            btnEditKasir.Name = "btnEditKasir";
            btnEditKasir.Size = new Size(84, 35);
            btnEditKasir.TabIndex = 7;
            btnEditKasir.Text = "Edit";
            btnEditKasir.UseVisualStyleBackColor = true;
            // 
            // isiEmail
            // 
            isiEmail.AutoSize = true;
            isiEmail.Font = new Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiEmail.Location = new Point(133, 99);
            isiEmail.Name = "isiEmail";
            isiEmail.Size = new Size(126, 50);
            isiEmail.TabIndex = 6;
            isiEmail.Text = "isiEmail";
            // 
            // btnHapusKasir
            // 
            btnHapusKasir.Location = new Point(354, 225);
            btnHapusKasir.Name = "btnHapusKasir";
            btnHapusKasir.Size = new Size(84, 35);
            btnHapusKasir.TabIndex = 5;
            btnHapusKasir.Text = "Hapus";
            btnHapusKasir.UseVisualStyleBackColor = true;
            // 
            // isiNoHP
            // 
            isiNoHP.AutoSize = true;
            isiNoHP.Font = new Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isiNoHP.Location = new Point(136, 167);
            isiNoHP.Name = "isiNoHP";
            isiNoHP.Size = new Size(125, 50);
            isiNoHP.TabIndex = 4;
            isiNoHP.Text = "isiNoHp";
            // 
            // lblNoHP
            // 
            lblNoHP.AutoSize = true;
            lblNoHP.Font = new Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoHP.Location = new Point(17, 167);
            lblNoHP.Name = "lblNoHP";
            lblNoHP.Size = new Size(113, 50);
            lblNoHP.TabIndex = 3;
            lblNoHP.Text = "No HP :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(17, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(110, 50);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email :";
            // 
            // lblNamaKasir
            // 
            lblNamaKasir.AutoSize = true;
            lblNamaKasir.Font = new Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaKasir.Location = new Point(17, 28);
            lblNamaKasir.Name = "lblNamaKasir";
            lblNamaKasir.Size = new Size(182, 50);
            lblNamaKasir.TabIndex = 0;
            lblNamaKasir.Text = "Nama Kasir";
            // 
            // btnTambahKasir
            // 
            btnTambahKasir.Location = new Point(1645, 153);
            btnTambahKasir.Name = "btnTambahKasir";
            btnTambahKasir.Size = new Size(194, 40);
            btnTambahKasir.TabIndex = 1;
            btnTambahKasir.Text = "Tambah Kasir";
            btnTambahKasir.UseVisualStyleBackColor = true;
            btnTambahKasir.Click += btnTambahKasir_Click;
            // 
            // btnKembaliMK
            // 
            btnKembaliMK.BackColor = Color.YellowGreen;
            btnKembaliMK.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKembaliMK.Location = new Point(367, 20);
            btnKembaliMK.Name = "btnKembaliMK";
            btnKembaliMK.Size = new Size(165, 44);
            btnKembaliMK.TabIndex = 8;
            btnKembaliMK.Text = "Kembali";
            btnKembaliMK.UseVisualStyleBackColor = false;
            btnKembaliMK.Click += btnKembaliMK_Click;
            // 
            // V_ManajemenKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.managemen_akun_kasir;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnKembaliMK);
            Controls.Add(btnTambahKasir);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "V_ManajemenKasir";
            Text = "V_ManajemenKasir";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblNamaKasir;
        private Label lblEmail;
        private Label isiNoHP;
        private Label lblNoHP;
        private Button btnTambahKasir;
        private Button btnEditKasir;
        private Label isiEmail;
        private Button btnHapusKasir;
        private Button btnKembaliMK;
    }
}