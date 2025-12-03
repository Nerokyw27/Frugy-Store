namespace Frugy_Store.Views.View_Admin
{
    partial class V_BerandaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_BerandaAdmin));
            btnTransaksiAdm = new Button();
            btnLaporanAdm = new Button();
            btnProdukAdm = new Button();
            button2 = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnTransaksiAdm
            // 
            btnTransaksiAdm.BackColor = Color.Transparent;
            btnTransaksiAdm.BackgroundImage = Properties.Resources.TransaksiBtn;
            btnTransaksiAdm.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransaksiAdm.FlatAppearance.BorderSize = 0;
            btnTransaksiAdm.FlatStyle = FlatStyle.Flat;
            btnTransaksiAdm.Location = new Point(471, 101);
            btnTransaksiAdm.Margin = new Padding(3, 2, 3, 2);
            btnTransaksiAdm.Name = "btnTransaksiAdm";
            btnTransaksiAdm.Size = new Size(422, 856);
            btnTransaksiAdm.TabIndex = 0;
            btnTransaksiAdm.UseVisualStyleBackColor = false;
            btnTransaksiAdm.Click += btnTransaksiAdm_Click;
            // 
            // btnLaporanAdm
            // 
            btnLaporanAdm.BackColor = Color.Transparent;
            btnLaporanAdm.BackgroundImage = Properties.Resources.LaporanBtn;
            btnLaporanAdm.BackgroundImageLayout = ImageLayout.Zoom;
            btnLaporanAdm.FlatAppearance.BorderSize = 0;
            btnLaporanAdm.FlatStyle = FlatStyle.Flat;
            btnLaporanAdm.Location = new Point(945, 157);
            btnLaporanAdm.Margin = new Padding(3, 2, 3, 2);
            btnLaporanAdm.Name = "btnLaporanAdm";
            btnLaporanAdm.Size = new Size(424, 761);
            btnLaporanAdm.TabIndex = 1;
            btnLaporanAdm.UseVisualStyleBackColor = false;
            btnLaporanAdm.Click += btnLaporanAdm_Click;
            // 
            // btnProdukAdm
            // 
            btnProdukAdm.BackColor = Color.Transparent;
            btnProdukAdm.BackgroundImage = Properties.Resources.ProdukBtn;
            btnProdukAdm.BackgroundImageLayout = ImageLayout.Zoom;
            btnProdukAdm.FlatAppearance.BorderSize = 0;
            btnProdukAdm.FlatStyle = FlatStyle.Flat;
            btnProdukAdm.Location = new Point(22, 140);
            btnProdukAdm.Margin = new Padding(3, 2, 3, 2);
            btnProdukAdm.Name = "btnProdukAdm";
            btnProdukAdm.Size = new Size(419, 778);
            btnProdukAdm.TabIndex = 2;
            btnProdukAdm.UseVisualStyleBackColor = false;
            btnProdukAdm.Click += btnProdukAdm_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.ManageAkunBtn;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1423, 140);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(448, 834);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(313, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(345, 61);
            btnLogout.TabIndex = 4;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // V_BerandaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tampilan_Utama_Admin_kosongan;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnLogout);
            Controls.Add(button2);
            Controls.Add(btnProdukAdm);
            Controls.Add(btnLaporanAdm);
            Controls.Add(btnTransaksiAdm);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_BerandaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_BerandaAdmin";
            Load += V_BerandaAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTransaksiAdm;
        private Button btnLaporanAdm;
        private Button btnProdukAdm;
        private Button button2;
        private Button btnLogout;
    }
}