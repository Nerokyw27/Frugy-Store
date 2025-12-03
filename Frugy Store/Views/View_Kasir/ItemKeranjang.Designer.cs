namespace Frugy_Store.Views.View_Kasir
{
    partial class ItemKeranjang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemKeranjang));
            lblNama = new Label();
            lblDetail = new Label();
            btnHapus = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(33, 19);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(108, 21);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama Produk";
            // 
            // lblDetail
            // 
            lblDetail.AutoSize = true;
            lblDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetail.Location = new Point(33, 56);
            lblDetail.Name = "lblDetail";
            lblDetail.Size = new Size(50, 21);
            lblDetail.TabIndex = 1;
            lblDetail.Text = "Detail";
            // 
            // btnHapus
            // 
            btnHapus.BackgroundImage = (Image)resources.GetObject("btnHapus.BackgroundImage");
            btnHapus.BackgroundImageLayout = ImageLayout.Zoom;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.Location = new Point(257, 8);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(29, 32);
            btnHapus.TabIndex = 2;
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // ItemKeranjang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnHapus);
            Controls.Add(lblDetail);
            Controls.Add(lblNama);
            ForeColor = SystemColors.Desktop;
            Name = "ItemKeranjang";
            Padding = new Padding(10, 5, 10, 5);
            Size = new Size(310, 100);
            Load += ItemKeranjang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblDetail;
        private Button btnHapus;
    }
}
