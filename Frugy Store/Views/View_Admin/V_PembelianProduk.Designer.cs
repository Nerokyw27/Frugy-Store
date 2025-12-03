namespace Frugy_Store.Views.View_Admin
{
    partial class V_PembelianProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_PembelianProduk));
            flowPanelProduk = new FlowLayoutPanel();
            flowPanelKeranjang = new FlowLayoutPanel();
            txtCari = new TextBox();
            btnSimpan = new Button();
            lblTotalItem = new Label();
            SuspendLayout();
            // 
            // flowPanelProduk
            // 
            flowPanelProduk.AutoScroll = true;
            flowPanelProduk.BackColor = Color.Transparent;
            flowPanelProduk.Location = new Point(380, 285);
            flowPanelProduk.Name = "flowPanelProduk";
            flowPanelProduk.Size = new Size(1100, 744);
            flowPanelProduk.TabIndex = 0;
            flowPanelProduk.Paint += flowPanelProduk_Paint;
            // 
            // flowPanelKeranjang
            // 
            flowPanelKeranjang.AutoScroll = true;
            flowPanelKeranjang.BackColor = Color.Transparent;
            flowPanelKeranjang.Location = new Point(1603, 366);
            flowPanelKeranjang.Name = "flowPanelKeranjang";
            flowPanelKeranjang.Size = new Size(275, 560);
            flowPanelKeranjang.TabIndex = 1;
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.Honeydew;
            txtCari.BorderStyle = BorderStyle.None;
            txtCari.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCari.Location = new Point(395, 139);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(1021, 28);
            txtCari.TabIndex = 2;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Image = (Image)resources.GetObject("btnSimpan.Image");
            btnSimpan.Location = new Point(1547, 954);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(384, 79);
            btnSimpan.TabIndex = 3;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.BackColor = Color.Transparent;
            lblTotalItem.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItem.Location = new Point(1603, 307);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(124, 32);
            lblTotalItem.TabIndex = 4;
            lblTotalItem.Text = "Total Item";
            // 
            // V_PembelianProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblTotalItem);
            Controls.Add(btnSimpan);
            Controls.Add(txtCari);
            Controls.Add(flowPanelKeranjang);
            Controls.Add(flowPanelProduk);
            Name = "V_PembelianProduk";
            Text = "V_PembelianProduk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanelProduk;
        private FlowLayoutPanel flowPanelKeranjang;
        private TextBox txtCari;
        private Button btnSimpan;
        private Label lblTotalItem;
    }
}