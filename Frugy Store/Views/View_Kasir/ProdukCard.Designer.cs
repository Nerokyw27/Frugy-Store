namespace Frugy_Store.Views.View_Kasir
{
    partial class ProdukCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdukCard));
            pbGambar = new PictureBox();
            lblNama = new Label();
            lblHarga = new Label();
            lblQty = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            lblStok = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGambar).BeginInit();
            SuspendLayout();
            // 
            // pbGambar
            // 
            pbGambar.BackgroundImage = (Image)resources.GetObject("pbGambar.BackgroundImage");
            pbGambar.Location = new Point(18, 22);
            pbGambar.Name = "pbGambar";
            pbGambar.Size = new Size(237, 184);
            pbGambar.TabIndex = 0;
            pbGambar.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.Black;
            lblNama.Location = new Point(48, 209);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(171, 32);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Produk";
            // 
            // lblHarga
            // 
            lblHarga.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(98, 241);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(63, 25);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Harga";
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQty.Location = new Point(112, 302);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(24, 30);
            lblQty.TabIndex = 3;
            lblQty.Text = "0";
            // 
            // btnPlus
            // 
            btnPlus.BackgroundImage = (Image)resources.GetObject("btnPlus.BackgroundImage");
            btnPlus.Cursor = Cursors.Hand;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(162, 302);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(34, 34);
            btnPlus.TabIndex = 4;
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackgroundImage = (Image)resources.GetObject("btnMinus.BackgroundImage");
            btnMinus.Cursor = Cursors.Hand;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Location = new Point(48, 302);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(34, 34);
            btnMinus.TabIndex = 5;
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblStok
            // 
            lblStok.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStok.AutoSize = true;
            lblStok.FlatStyle = FlatStyle.Flat;
            lblStok.Location = new Point(112, 275);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(30, 15);
            lblStok.TabIndex = 6;
            lblStok.Text = "Stok";
            // 
            // ProdukCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(lblStok);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(lblQty);
            Controls.Add(lblHarga);
            Controls.Add(lblNama);
            Controls.Add(pbGambar);
            Name = "ProdukCard";
            Size = new Size(269, 379);
            Load += ProdukCard_Load;
            ((System.ComponentModel.ISupportInitialize)pbGambar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGambar;
        private Label lblNama;
        private Label lblHarga;
        private Label lblQty;
        private Button btnPlus;
        private Button btnMinus;
        private Label lblStok;
    }
}
