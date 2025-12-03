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
            btnTransaksiKsr.Location = new Point(240, 94);
            btnTransaksiKsr.Margin = new Padding(3, 2, 3, 2);
            btnTransaksiKsr.Name = "btnTransaksiKsr";
            btnTransaksiKsr.Size = new Size(584, 949);
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
            btnLaporanKsr.Location = new Point(976, 94);
            btnLaporanKsr.Margin = new Padding(3, 2, 3, 2);
            btnLaporanKsr.Name = "btnLaporanKsr";
            btnLaporanKsr.Size = new Size(551, 949);
            btnLaporanKsr.TabIndex = 1;
            btnLaporanKsr.UseVisualStyleBackColor = false;
            btnLaporanKsr.Click += btnLaporanKsr_Click;
            // 
            // btnLogoutKsr
            // 
            btnLogoutKsr.BackColor = Color.YellowGreen;
            btnLogoutKsr.BackgroundImageLayout = ImageLayout.None;
            btnLogoutKsr.FlatAppearance.BorderSize = 0;
            btnLogoutKsr.FlatStyle = FlatStyle.Flat;
            btnLogoutKsr.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogoutKsr.Location = new Point(650, 20);
            btnLogoutKsr.Margin = new Padding(3, 2, 3, 2);
            btnLogoutKsr.Name = "btnLogoutKsr";
            btnLogoutKsr.Size = new Size(156, 38);
            btnLogoutKsr.TabIndex = 2;
            btnLogoutKsr.Text = "Logout";
            btnLogoutKsr.UseVisualStyleBackColor = false;
            // 
            // V_BerandaKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tampilan_Utama_Kasir__1_;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnLogoutKsr);
            Controls.Add(btnLaporanKsr);
            Controls.Add(btnTransaksiKsr);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_BerandaKasir";
            Text = "V_BerandaKasir";
            WindowState = FormWindowState.Maximized;
            Load += V_BerandaKasir_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTransaksiKsr;
        private Button btnLaporanKsr;
        private Button btnLogoutKsr;
    }
}