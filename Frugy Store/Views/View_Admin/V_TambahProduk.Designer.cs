namespace Frugy_Store.Views.View_Admin
{
    partial class V_TambahProduk
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
            panel1 = new Panel();
            cbSayur = new CheckBox();
            cbBuah = new CheckBox();
            tbSatuan = new TextBox();
            Satuan = new Label();
            btnSave = new Button();
            tbStokBrg = new TextBox();
            StokBrg = new Label();
            btnUpload = new Button();
            pictureBox1 = new PictureBox();
            UploadFoto = new Label();
            tbHarga = new TextBox();
            tbKadaluarsa = new TextBox();
            tbTglMasuk = new TextBox();
            tbNamaBuahSayur = new TextBox();
            Harga = new Label();
            Kadaluarsa = new Label();
            tglMasuk = new Label();
            namaBuahSayur = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Rectangle_16_2x;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(cbSayur);
            panel1.Controls.Add(cbBuah);
            panel1.Controls.Add(tbSatuan);
            panel1.Controls.Add(Satuan);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(tbStokBrg);
            panel1.Controls.Add(StokBrg);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(UploadFoto);
            panel1.Controls.Add(tbHarga);
            panel1.Controls.Add(tbKadaluarsa);
            panel1.Controls.Add(tbTglMasuk);
            panel1.Controls.Add(tbNamaBuahSayur);
            panel1.Controls.Add(Harga);
            panel1.Controls.Add(Kadaluarsa);
            panel1.Controls.Add(tglMasuk);
            panel1.Controls.Add(namaBuahSayur);
            panel1.Location = new Point(419, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 937);
            panel1.TabIndex = 0;
            // 
            // cbSayur
            // 
            cbSayur.AutoSize = true;
            cbSayur.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSayur.Location = new Point(922, 117);
            cbSayur.Name = "cbSayur";
            cbSayur.Size = new Size(104, 44);
            cbSayur.TabIndex = 17;
            cbSayur.Text = "Sayur";
            cbSayur.UseVisualStyleBackColor = true;
            cbSayur.CheckedChanged += cbSayur_CheckedChanged;
            // 
            // cbBuah
            // 
            cbBuah.AutoSize = true;
            cbBuah.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBuah.Location = new Point(922, 165);
            cbBuah.Name = "cbBuah";
            cbBuah.Size = new Size(98, 44);
            cbBuah.TabIndex = 16;
            cbBuah.Text = "Buah";
            cbBuah.UseVisualStyleBackColor = true;
            cbBuah.CheckedChanged += cbBuah_CheckedChanged;
            // 
            // tbSatuan
            // 
            tbSatuan.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSatuan.Location = new Point(257, 520);
            tbSatuan.Name = "tbSatuan";
            tbSatuan.Size = new Size(226, 42);
            tbSatuan.TabIndex = 15;
            // 
            // Satuan
            // 
            Satuan.AutoSize = true;
            Satuan.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Satuan.Location = new Point(248, 464);
            Satuan.Name = "Satuan";
            Satuan.Size = new Size(129, 53);
            Satuan.TabIndex = 14;
            Satuan.Text = "Satuan";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(967, 788);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(183, 44);
            btnSave.TabIndex = 13;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbStokBrg
            // 
            tbStokBrg.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStokBrg.Location = new Point(257, 403);
            tbStokBrg.Name = "tbStokBrg";
            tbStokBrg.Size = new Size(226, 42);
            tbStokBrg.TabIndex = 12;
            // 
            // StokBrg
            // 
            StokBrg.AutoSize = true;
            StokBrg.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StokBrg.Location = new Point(248, 347);
            StokBrg.Name = "StokBrg";
            StokBrg.Size = new Size(85, 53);
            StokBrg.TabIndex = 11;
            StokBrg.Text = "Stok";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(700, 759);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(182, 40);
            btnUpload.TabIndex = 10;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(678, 537);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // UploadFoto
            // 
            UploadFoto.AutoSize = true;
            UploadFoto.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UploadFoto.Location = new Point(687, 464);
            UploadFoto.Name = "UploadFoto";
            UploadFoto.Size = new Size(200, 53);
            UploadFoto.TabIndex = 8;
            UploadFoto.Text = "Upload Foto";
            // 
            // tbHarga
            // 
            tbHarga.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(678, 403);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(226, 42);
            tbHarga.TabIndex = 7;
            // 
            // tbKadaluarsa
            // 
            tbKadaluarsa.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbKadaluarsa.Location = new Point(678, 296);
            tbKadaluarsa.Name = "tbKadaluarsa";
            tbKadaluarsa.Size = new Size(226, 42);
            tbKadaluarsa.TabIndex = 6;
            // 
            // tbTglMasuk
            // 
            tbTglMasuk.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTglMasuk.Location = new Point(257, 296);
            tbTglMasuk.Name = "tbTglMasuk";
            tbTglMasuk.Size = new Size(226, 42);
            tbTglMasuk.TabIndex = 5;
            // 
            // tbNamaBuahSayur
            // 
            tbNamaBuahSayur.BackColor = SystemColors.Window;
            tbNamaBuahSayur.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaBuahSayur.Location = new Point(257, 167);
            tbNamaBuahSayur.Name = "tbNamaBuahSayur";
            tbNamaBuahSayur.Size = new Size(647, 42);
            tbNamaBuahSayur.TabIndex = 4;
            // 
            // Harga
            // 
            Harga.AutoSize = true;
            Harga.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Harga.Location = new Point(729, 347);
            Harga.Name = "Harga";
            Harga.Size = new Size(116, 53);
            Harga.TabIndex = 3;
            Harga.Text = "Harga";
            // 
            // Kadaluarsa
            // 
            Kadaluarsa.AutoSize = true;
            Kadaluarsa.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kadaluarsa.Location = new Point(687, 231);
            Kadaluarsa.Name = "Kadaluarsa";
            Kadaluarsa.Size = new Size(195, 53);
            Kadaluarsa.TabIndex = 2;
            Kadaluarsa.Text = "Kadaluarsa";
            // 
            // tglMasuk
            // 
            tglMasuk.AutoSize = true;
            tglMasuk.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tglMasuk.Location = new Point(248, 231);
            tglMasuk.Name = "tglMasuk";
            tglMasuk.Size = new Size(248, 53);
            tglMasuk.TabIndex = 1;
            tglMasuk.Text = "Tanggal Masuk";
            // 
            // namaBuahSayur
            // 
            namaBuahSayur.AutoSize = true;
            namaBuahSayur.Font = new Font("Poppins", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namaBuahSayur.Location = new Point(248, 108);
            namaBuahSayur.Name = "namaBuahSayur";
            namaBuahSayur.Size = new Size(294, 53);
            namaBuahSayur.TabIndex = 0;
            namaBuahSayur.Text = "Nama Buah/Sayur";
            // 
            // V_TambahProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tambah_produk;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "V_TambahProduk";
            Text = "V_TambahProduk";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label tglMasuk;
        private Label namaBuahSayur;
        private Label UploadFoto;
        private TextBox tbHarga;
        private TextBox tbKadaluarsa;
        private TextBox tbTglMasuk;
        private TextBox tbNamaBuahSayur;
        private Label Harga;
        private Label Kadaluarsa;
        private Button btnUpload;
        private PictureBox pictureBox1;
        private Label StokBrg;
        private Button btnSave;
        private TextBox tbStokBrg;
        private TextBox tbSatuan;
        private Label Satuan;
        private CheckBox cbBuah;
        private CheckBox cbSayur;
    }
}