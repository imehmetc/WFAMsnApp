namespace WFAMsnApp
{
    partial class Register
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
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            txtEmailAdress = new TextBox();
            btnRegister = new Button();
            lblLinkLogin = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkShowPassword = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            txtAge = new TextBox();
            txtGender = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.msn;
            pictureBox1.Location = new Point(99, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(64, 320);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 23);
            txtPassword.TabIndex = 13;
            // 
            // txtEmailAdress
            // 
            txtEmailAdress.Location = new Point(64, 262);
            txtEmailAdress.Name = "txtEmailAdress";
            txtEmailAdress.Size = new Size(198, 23);
            txtEmailAdress.TabIndex = 14;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegister.Location = new Point(100, 518);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 48);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnLogin_Click;
            // 
            // lblLinkLogin
            // 
            lblLinkLogin.AutoSize = true;
            lblLinkLogin.Location = new Point(16, 18);
            lblLinkLogin.Name = "lblLinkLogin";
            lblLinkLogin.Size = new Size(37, 15);
            lblLinkLogin.TabIndex = 11;
            lblLinkLogin.TabStop = true;
            lblLinkLogin.Text = "Login";
            lblLinkLogin.LinkClicked += lblLinkLogin_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(65, 297);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(65, 236);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 8;
            label2.Text = "E-mail adress:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 15F);
            label1.Location = new Point(120, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 9;
            label1.Text = "Register";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkShowPassword.Location = new Point(66, 479);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(112, 19);
            chkShowPassword.TabIndex = 17;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(66, 354);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(66, 415);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 7;
            label5.Text = "Gender:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(65, 380);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(198, 23);
            txtAge.TabIndex = 14;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(65, 438);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(198, 23);
            txtGender.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 638);
            Controls.Add(chkShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(txtGender);
            Controls.Add(txtAge);
            Controls.Add(txtPassword);
            Controls.Add(txtEmailAdress);
            Controls.Add(btnRegister);
            Controls.Add(lblLinkLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtEmailAdress;
        private Button btnRegister;
        private LinkLabel lblLinkLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkShowPassword;
        private Label label4;
        private Label label5;
        private TextBox txtAge;
        private TextBox txtGender;
    }
}