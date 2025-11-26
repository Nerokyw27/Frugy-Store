namespace Frugy_Store.Views.View_Kasir
{
    partial class V_BerandaKasir
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
            btnTransaksiKsr = new Button();
            btnLaporanKsr = new Button();
            btnLogoutKsr = new Button();
            SuspendLayout();
            // 
            // btnTransaksiKsr
            // 
            btnTransaksiKsr.BackColor = Color.Transparent;
            btnTransaksiKsr.BackgroundImage = Properties.Resources.TransaksiBtn;
            btnTransaksiKsr.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransaksiKsr.FlatAppearance.BorderSize = 0;
            btnTransaksiKsr.FlatStyle = FlatStyle.Flat;
            btnTransaksiKsr.Location = new Point(274, 125);
            btnTransaksiKsr.Name = "btnTransaksiKsr";
            btnTransaksiKsr.Size = new Size(535, 815);
            btnTransaksiKsr.TabIndex = 0;
            btnTransaksiKsr.UseVisualStyleBackColor = false;
            btnTransaksiKsr.Click += btnTransaksiKsr_Click;
            // 
            // btnLaporanKsr
            // 
            btnLaporanKsr.BackColor = Color.Transparent;
            btnLaporanKsr.BackgroundImage = Properties.Resources.LaporanBtn;
            btnLaporanKsr.BackgroundImageLayout = ImageLayout.Zoom;
            btnLaporanKsr.FlatAppearance.BorderSize = 0;
            btnLaporanKsr.FlatStyle = FlatStyle.Flat;
            btnLaporanKsr.Location = new Point(1115, 125);
            btnLaporanKsr.Name = "btnLaporanKsr";
            btnLaporanKsr.Size = new Size(535, 815);
            btnLaporanKsr.TabIndex = 1;
            btnLaporanKsr.UseVisualStyleBackColor = false;
            btnLaporanKsr.Click += btnLaporanKsr_Click;
            // 
            // btnLogoutKsr
            // 
            btnLogoutKsr.BackColor = Color.YellowGreen;
            btnLogoutKsr.BackgroundImageLayout = ImageLayout.None;
            btnLogoutKsr.FlatAppearance.BorderSize = 0;
            btnLogoutKsr.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogoutKsr.Location = new Point(648, 15);
            btnLogoutKsr.Name = "btnLogoutKsr";
            btnLogoutKsr.Size = new Size(178, 51);
            btnLogoutKsr.TabIndex = 2;
            btnLogoutKsr.Text = "Logout";
            btnLogoutKsr.UseVisualStyleBackColor = false;
            // 
            // V_BerandaKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tampilan_Utama_Kasir__1_;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnLogoutKsr);
            Controls.Add(btnLaporanKsr);
            Controls.Add(btnTransaksiKsr);
            Name = "V_BerandaKasir";
            Text = "V_BerandaKasir";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTransaksiKsr;
        private Button btnLaporanKsr;
        private Button btnLogoutKsr;
    }
}