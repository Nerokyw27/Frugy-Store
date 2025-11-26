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
            tbUsernameLgn = new TextBox();
            tbPasswordLgn = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // tbUsernameLgn
            // 
            tbUsernameLgn.Font = new Font("Poppins", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsernameLgn.Location = new Point(1275, 329);
            tbUsernameLgn.Name = "tbUsernameLgn";
            tbUsernameLgn.Size = new Size(519, 63);
            tbUsernameLgn.TabIndex = 0;
            // 
            // tbPasswordLgn
            // 
            tbPasswordLgn.Font = new Font("Poppins", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordLgn.Location = new Point(1275, 537);
            tbPasswordLgn.Name = "tbPasswordLgn";
            tbPasswordLgn.Size = new Size(519, 63);
            tbPasswordLgn.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Poppins", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(1263, 724);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(542, 83);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login_UI_fix__1_;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnLogin);
            Controls.Add(tbPasswordLgn);
            Controls.Add(tbUsernameLgn);
            Name = "V_Login";
            Text = "V_Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsernameLgn;
        private TextBox tbPasswordLgn;
        private Button btnLogin;
    }
}