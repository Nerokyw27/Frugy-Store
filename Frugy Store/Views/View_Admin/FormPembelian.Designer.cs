namespace Frugy_Store.Views.View_Admin
{
    partial class FormPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembelian));
            flowSummary = new FlowLayoutPanel();
            txtSupplier = new TextBox();
            btnSimpan = new Button();
            button1 = new Button();
            lblTotalItem = new Label();
            SuspendLayout();
            // 
            // flowSummary
            // 
            flowSummary.AutoScroll = true;
            flowSummary.BackColor = Color.Transparent;
            flowSummary.FlowDirection = FlowDirection.TopDown;
            flowSummary.Location = new Point(378, 250);
            flowSummary.Name = "flowSummary";
            flowSummary.Size = new Size(1459, 555);
            flowSummary.TabIndex = 0;
            // 
            // txtSupplier
            // 
            txtSupplier.BackColor = Color.Honeydew;
            txtSupplier.BorderStyle = BorderStyle.None;
            txtSupplier.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplier.Location = new Point(502, 850);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(340, 20);
            txtSupplier.TabIndex = 1;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Transparent;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Image = (Image)resources.GetObject("btnSimpan.Image");
            btnSimpan.Location = new Point(1543, 942);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(367, 68);
            btnSimpan.TabIndex = 2;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1196, 942);
            button1.Name = "button1";
            button1.Size = new Size(367, 68);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTotalItem
            // 
            lblTotalItem.AutoSize = true;
            lblTotalItem.BackColor = Color.Transparent;
            lblTotalItem.FlatStyle = FlatStyle.Flat;
            lblTotalItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItem.Location = new Point(1506, 196);
            lblTotalItem.Name = "lblTotalItem";
            lblTotalItem.Size = new Size(100, 25);
            lblTotalItem.TabIndex = 4;
            lblTotalItem.Text = "Total Item";
            // 
            // FormPembelian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblTotalItem);
            Controls.Add(button1);
            Controls.Add(btnSimpan);
            Controls.Add(txtSupplier);
            Controls.Add(flowSummary);
            Name = "FormPembelian";
            Text = "FormPembelian";
            Load += FormPembelian_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowSummary;
        private TextBox txtSupplier;
        private Button btnSimpan;
        private Button button1;
        private Label lblTotalItem;
    }
}