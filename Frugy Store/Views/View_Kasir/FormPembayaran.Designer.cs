namespace Frugy_Store.Views.View_Kasir
{
    partial class FormPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembayaran));
            flowSummary = new FlowLayoutPanel();
            lblJudulTotal = new Label();
            lblTotalBayar = new Label();
            rbCash = new RadioButton();
            rbQR = new RadioButton();
            labelUang = new Label();
            txtUangMasuk = new TextBox();
            lblKembalian = new Label();
            btnBayar = new Button();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // flowSummary
            // 
            flowSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowSummary.AutoScroll = true;
            flowSummary.BackColor = Color.Transparent;
            flowSummary.Location = new Point(394, 335);
            flowSummary.Name = "flowSummary";
            flowSummary.Size = new Size(996, 555);
            flowSummary.TabIndex = 0;
            // 
            // lblJudulTotal
            // 
            lblJudulTotal.AutoSize = true;
            lblJudulTotal.BackColor = Color.Transparent;
            lblJudulTotal.FlatStyle = FlatStyle.Flat;
            lblJudulTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulTotal.Location = new Point(763, 138);
            lblJudulTotal.Name = "lblJudulTotal";
            lblJudulTotal.Size = new Size(220, 45);
            lblJudulTotal.TabIndex = 1;
            lblJudulTotal.Text = "Total Tagihan";
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.AutoSize = true;
            lblTotalBayar.BackColor = Color.Transparent;
            lblTotalBayar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBayar.Location = new Point(823, 217);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(88, 45);
            lblTotalBayar.TabIndex = 2;
            lblTotalBayar.Text = "Rp 0";
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.BackColor = Color.Transparent;
            rbCash.Checked = true;
            rbCash.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbCash.Location = new Point(1539, 176);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(152, 69);
            rbCash.TabIndex = 3;
            rbCash.TabStop = true;
            rbCash.Text = "Cash";
            rbCash.UseVisualStyleBackColor = false;
            rbCash.CheckedChanged += rbCash_CheckedChanged;
            // 
            // rbQR
            // 
            rbQR.AutoSize = true;
            rbQR.BackColor = Color.Transparent;
            rbQR.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbQR.Location = new Point(1539, 273);
            rbQR.Name = "rbQR";
            rbQR.Size = new Size(136, 69);
            rbQR.TabIndex = 4;
            rbQR.TabStop = true;
            rbQR.Text = "Qris";
            rbQR.UseVisualStyleBackColor = false;
            rbQR.CheckedChanged += rbQR_CheckedChanged;
            // 
            // labelUang
            // 
            labelUang.AutoSize = true;
            labelUang.BackColor = Color.Transparent;
            labelUang.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUang.Location = new Point(1603, 672);
            labelUang.Name = "labelUang";
            labelUang.Size = new Size(152, 30);
            labelUang.TabIndex = 5;
            labelUang.Text = "Uang Diterima";
            // 
            // txtUangMasuk
            // 
            txtUangMasuk.BackColor = Color.Honeydew;
            txtUangMasuk.BorderStyle = BorderStyle.None;
            txtUangMasuk.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUangMasuk.Location = new Point(1522, 722);
            txtUangMasuk.Name = "txtUangMasuk";
            txtUangMasuk.Size = new Size(304, 32);
            txtUangMasuk.TabIndex = 6;
            txtUangMasuk.TextChanged += lblKembalian_TextChanged;
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.BackColor = Color.Transparent;
            lblKembalian.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKembalian.Location = new Point(1522, 818);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(66, 32);
            lblKembalian.TabIndex = 7;
            lblKembalian.Text = "Rp 0";
            lblKembalian.TextChanged += lblKembalian_TextChanged;
            lblKembalian.Click += lblKembalian_Click;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.Transparent;
            btnBayar.FlatAppearance.BorderSize = 0;
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Location = new Point(1522, 904);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(311, 61);
            btnBayar.TabIndex = 8;
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.Location = new Point(415, 960);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(280, 54);
            btnKembali.TabIndex = 9;
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += btnKembali_Click;
            // 
            // FormPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnKembali);
            Controls.Add(btnBayar);
            Controls.Add(lblKembalian);
            Controls.Add(txtUangMasuk);
            Controls.Add(labelUang);
            Controls.Add(rbQR);
            Controls.Add(rbCash);
            Controls.Add(lblTotalBayar);
            Controls.Add(lblJudulTotal);
            Controls.Add(flowSummary);
            Name = "FormPembayaran";
            Text = "FormPembayaran";
            Load += FormPembayaran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowSummary;
        private Label lblJudulTotal;
        private Label lblTotalBayar;
        private RadioButton rbCash;
        private RadioButton rbQR;
        private Label labelUang;
        private TextBox txtUangMasuk;
        private Label lblKembalian;
        private Button btnBayar;
        private Button btnKembali;
    }
}