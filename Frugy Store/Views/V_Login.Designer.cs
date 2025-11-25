namespace Frugy_Store.Views
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
            panel1 = new Panel();
            HalLogin = new Label();
            usnLabel = new Label();
            passLabel = new Label();
            tbUsernameLgn = new TextBox();
            tbPasswordLgn = new TextBox();
            btnLogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Logins;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(tbPasswordLgn);
            panel1.Controls.Add(tbUsernameLgn);
            panel1.Controls.Add(passLabel);
            panel1.Controls.Add(usnLabel);
            panel1.Controls.Add(HalLogin);
            panel1.Location = new Point(450, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 453);
            panel1.TabIndex = 0;
            // 
            // HalLogin
            // 
            HalLogin.AutoSize = true;
            HalLogin.BackColor = Color.Transparent;
            HalLogin.Font = new Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HalLogin.ForeColor = Color.White;
            HalLogin.Location = new Point(122, 88);
            HalLogin.Name = "HalLogin";
            HalLogin.Size = new Size(110, 41);
            HalLogin.TabIndex = 0;
            HalLogin.Text = "Login";
            // 
            // usnLabel
            // 
            usnLabel.AutoSize = true;
            usnLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usnLabel.ForeColor = Color.White;
            usnLabel.Location = new Point(21, 149);
            usnLabel.Name = "usnLabel";
            usnLabel.Size = new Size(84, 18);
            usnLabel.TabIndex = 1;
            usnLabel.Text = "Username";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passLabel.ForeColor = Color.White;
            passLabel.Location = new Point(21, 253);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(80, 18);
            passLabel.TabIndex = 2;
            passLabel.Text = "Password";
            // 
            // tbUsernameLgn
            // 
            tbUsernameLgn.BorderStyle = BorderStyle.None;
            tbUsernameLgn.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsernameLgn.Location = new Point(39, 187);
            tbUsernameLgn.Name = "tbUsernameLgn";
            tbUsernameLgn.Size = new Size(272, 28);
            tbUsernameLgn.TabIndex = 3;
            // 
            // tbPasswordLgn
            // 
            tbPasswordLgn.BorderStyle = BorderStyle.None;
            tbPasswordLgn.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordLgn.Location = new Point(39, 289);
            tbPasswordLgn.Name = "tbPasswordLgn";
            tbPasswordLgn.Size = new Size(272, 28);
            tbPasswordLgn.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.YellowGreen;
            btnLogin.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(60, 360);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(237, 52);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login_UI_fix;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "V_Login";
            Text = "V_Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label HalLogin;
        private TextBox tbUsernameLgn;
        private Label passLabel;
        private Label usnLabel;
        private Button btnLogin;
        private TextBox tbPasswordLgn;
    }
}