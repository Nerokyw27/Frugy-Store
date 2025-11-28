namespace Frugy_Store.Views.View_Kasir
{
    partial class V_TransaksiKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TransaksiKasir));
            flowPanelProduk = new FlowLayoutPanel();
            btnLanjut = new Button();
            btnKembali = new Button();
            flowKeranjang = new FlowLayoutPanel();
            lblTotalBayar = new Label();
            lblbiasa = new Label();
            txtCari = new TextBox();
            SuspendLayout();
            // 
            // flowPanelProduk
            // 
            flowPanelProduk.AutoScroll = true;
            flowPanelProduk.BackColor = Color.Transparent;
            flowPanelProduk.Location = new Point(380, 281);
            flowPanelProduk.Name = "flowPanelProduk";
            flowPanelProduk.Size = new Size(1104, 1080);
            flowPanelProduk.TabIndex = 0;
            // 
            // btnLanjut
            // 
            btnLanjut.BackColor = Color.Transparent;
            btnLanjut.BackgroundImage = (Image)resources.GetObject("btnLanjut.BackgroundImage");
            btnLanjut.BackgroundImageLayout = ImageLayout.None;
            btnLanjut.Cursor = Cursors.Hand;
            btnLanjut.FlatAppearance.BorderSize = 0;
            btnLanjut.FlatStyle = FlatStyle.Flat;
            btnLanjut.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLanjut.Location = new Point(1585, 951);
            btnLanjut.Name = "btnLanjut";
            btnLanjut.Size = new Size(307, 78);
            btnLanjut.TabIndex = 1;
            btnLanjut.Text = "Lanjut";
            btnLanjut.UseVisualStyleBackColor = false;
            btnLanjut.Click += btnLanjut_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Location = new Point(344, 12);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(270, 55);
            btnKembali.TabIndex = 2;
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // flowKeranjang
            // 
            flowKeranjang.AutoScroll = true;
            flowKeranjang.BackColor = Color.Transparent;
            flowKeranjang.FlowDirection = FlowDirection.TopDown;
            flowKeranjang.Location = new Point(1601, 403);
            flowKeranjang.Name = "flowKeranjang";
            flowKeranjang.Size = new Size(276, 542);
            flowKeranjang.TabIndex = 4;
            flowKeranjang.WrapContents = false;
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.AutoSize = true;
            lblTotalBayar.BackColor = Color.Transparent;
            lblTotalBayar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBayar.Location = new Point(1695, 340);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(106, 25);
            lblTotalBayar.TabIndex = 5;
            lblTotalBayar.Text = "Total Bayar";
            // 
            // lblbiasa
            // 
            lblbiasa.AutoSize = true;
            lblbiasa.BackColor = Color.Transparent;
            lblbiasa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbiasa.Location = new Point(1667, 272);
            lblbiasa.Name = "lblbiasa";
            lblbiasa.Size = new Size(162, 37);
            lblbiasa.TabIndex = 6;
            lblbiasa.Text = "Total Bayar";
            // 
            // txtCari
            // 
            txtCari.BackColor = Color.Honeydew;
            txtCari.BorderStyle = BorderStyle.None;
            txtCari.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCari.ForeColor = Color.Transparent;
            txtCari.Location = new Point(391, 134);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(1022, 43);
            txtCari.TabIndex = 7;
            // 
            // V_TransaksiKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(txtCari);
            Controls.Add(lblbiasa);
            Controls.Add(lblTotalBayar);
            Controls.Add(flowKeranjang);
            Controls.Add(btnKembali);
            Controls.Add(btnLanjut);
            Controls.Add(flowPanelProduk);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_TransaksiKasir";
            Text = "V_TransaksiKasir";
            WindowState = FormWindowState.Maximized;
            Load += V_TransaksiKasir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowPanelProduk;
        private Button btnLanjut;
        private Button btnKembali;
        private FlowLayoutPanel flowKeranjang;
        private Label lblTotalBayar;
        private Label lblbiasa;
        private TextBox txtCari;
    }
}