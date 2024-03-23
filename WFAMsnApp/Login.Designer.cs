namespace WFAMsnApp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblLinkChangePassword = new LinkLabel();
            lblLinkRegister = new LinkLabel();
            btnLogin = new Button();
            txtEmailAdress = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 15F);
            label1.Location = new Point(137, 44);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(68, 248);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "E-mail adress:";
            // 
            // lblLinkChangePassword
            // 
            lblLinkChangePassword.AutoSize = true;
            lblLinkChangePassword.Location = new Point(24, 603);
            lblLinkChangePassword.Name = "lblLinkChangePassword";
            lblLinkChangePassword.Size = new Size(132, 15);
            lblLinkChangePassword.TabIndex = 1;
            lblLinkChangePassword.TabStop = true;
            lblLinkChangePassword.Text = "Forgot your password?";
            lblLinkChangePassword.LinkClicked += lblLinkChangePassword_LinkClicked;
            // 
            // lblLinkRegister
            // 
            lblLinkRegister.AutoSize = true;
            lblLinkRegister.Location = new Point(227, 603);
            lblLinkRegister.Name = "lblLinkRegister";
            lblLinkRegister.Size = new Size(111, 15);
            lblLinkRegister.TabIndex = 2;
            lblLinkRegister.TabStop = true;
            lblLinkRegister.Text = "Get a new account";
            lblLinkRegister.LinkClicked += lblLinkRegister_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(104, 441);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmailAdress
            // 
            txtEmailAdress.Location = new Point(67, 274);
            txtEmailAdress.Name = "txtEmailAdress";
            txtEmailAdress.Size = new Size(198, 23);
            txtEmailAdress.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.msn;
            pictureBox1.Location = new Point(103, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(68, 309);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(67, 332);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 23);
            txtPassword.TabIndex = 4;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkShowPassword.Location = new Point(68, 388);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(112, 19);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 638);
            Controls.Add(chkShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmailAdress);
            Controls.Add(btnLogin);
            Controls.Add(lblLinkRegister);
            Controls.Add(lblLinkChangePassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private LinkLabel lblLinkChangePassword;
        private LinkLabel lblLinkRegister;
        private Button btnLogin;
        private TextBox txtEmailAdress;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
    }
}
