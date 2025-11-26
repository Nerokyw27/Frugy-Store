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
            btnTransaksiAdm = new Button();
            btnLaporanAdm = new Button();
            btnProdukAdm = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnTransaksiAdm
            // 
            btnTransaksiAdm.BackColor = Color.Transparent;
            btnTransaksiAdm.BackgroundImage = Properties.Resources.TransaksiBtn;
            btnTransaksiAdm.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransaksiAdm.FlatAppearance.BorderSize = 0;
            btnTransaksiAdm.FlatStyle = FlatStyle.Flat;
            btnTransaksiAdm.Location = new Point(529, 125);
            btnTransaksiAdm.Name = "btnTransaksiAdm";
            btnTransaksiAdm.Size = new Size(400, 750);
            btnTransaksiAdm.TabIndex = 0;
            btnTransaksiAdm.UseVisualStyleBackColor = false;
            // 
            // btnLaporanAdm
            // 
            btnLaporanAdm.BackColor = Color.Transparent;
            btnLaporanAdm.BackgroundImage = Properties.Resources.LaporanBtn;
            btnLaporanAdm.BackgroundImageLayout = ImageLayout.Zoom;
            btnLaporanAdm.FlatAppearance.BorderSize = 0;
            btnLaporanAdm.FlatStyle = FlatStyle.Flat;
            btnLaporanAdm.Location = new Point(989, 125);
            btnLaporanAdm.Name = "btnLaporanAdm";
            btnLaporanAdm.Size = new Size(400, 750);
            btnLaporanAdm.TabIndex = 1;
            btnLaporanAdm.UseVisualStyleBackColor = false;
            // 
            // btnProdukAdm
            // 
            btnProdukAdm.BackColor = Color.Transparent;
            btnProdukAdm.BackgroundImage = Properties.Resources.ProdukBtn;
            btnProdukAdm.BackgroundImageLayout = ImageLayout.Zoom;
            btnProdukAdm.FlatAppearance.BorderSize = 0;
            btnProdukAdm.FlatStyle = FlatStyle.Flat;
            btnProdukAdm.Location = new Point(58, 125);
            btnProdukAdm.Name = "btnProdukAdm";
            btnProdukAdm.Size = new Size(400, 750);
            btnProdukAdm.TabIndex = 2;
            btnProdukAdm.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.ManageAkunBtn;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1436, 118);
            button2.Name = "button2";
            button2.Size = new Size(408, 760);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // V_BerandaAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tampilan_Utama_Admin_kosongan;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(btnProdukAdm);
            Controls.Add(btnLaporanAdm);
            Controls.Add(btnTransaksiAdm);
            Name = "V_BerandaAdmin";
            Text = "V_BerandaAdmin";
            Load += V_BerandaAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTransaksiAdm;
        private Button btnLaporanAdm;
        private Button btnProdukAdm;
        private Button button2;
    }
}