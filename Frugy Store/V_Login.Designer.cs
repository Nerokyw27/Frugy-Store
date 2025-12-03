namespace Frugy_Store
{
    partial class V_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            tbUsernameLgn = new TextBox();
            tbPasswordLgn = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // tbUsernameLgn
            // 
            tbUsernameLgn.BorderStyle = BorderStyle.None;
            tbUsernameLgn.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsernameLgn.Location = new Point(1267, 343);
            tbUsernameLgn.Margin = new Padding(3, 2, 3, 2);
            tbUsernameLgn.Name = "tbUsernameLgn";
            tbUsernameLgn.Size = new Size(517, 34);
            tbUsernameLgn.TabIndex = 0;
            // 
            // tbPasswordLgn
            // 
            tbPasswordLgn.BorderStyle = BorderStyle.None;
            tbPasswordLgn.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordLgn.Location = new Point(1267, 535);
            tbPasswordLgn.Margin = new Padding(3, 2, 3, 2);
            tbPasswordLgn.Name = "tbPasswordLgn";
            tbPasswordLgn.Size = new Size(517, 34);
            tbPasswordLgn.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(1292, 862);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(474, 62);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1664, 775);
            Controls.Add(btnLogin);
            Controls.Add(tbPasswordLgn);
            Controls.Add(tbUsernameLgn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Login";
            Load += V_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsernameLgn;
        private TextBox tbPasswordLgn;
        private Button btnLogin;
    }
}