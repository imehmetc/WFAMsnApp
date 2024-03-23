namespace WFAMsnApp
{
    partial class ChangePassword
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
            chkShowPassword = new CheckBox();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            txtEmailAdress = new TextBox();
            btnChangePassword = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtPassword2 = new TextBox();
            lblLinkLogin = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkShowPassword.Location = new Point(71, 466);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(112, 19);
            chkShowPassword.TabIndex = 15;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.msn;
            pictureBox1.Location = new Point(106, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(70, 346);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtEmailAdress
            // 
            txtEmailAdress.Location = new Point(70, 288);
            txtEmailAdress.Name = "txtEmailAdress";
            txtEmailAdress.Size = new Size(198, 23);
            txtEmailAdress.TabIndex = 12;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChangePassword.Location = new Point(71, 524);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(184, 48);
            btnChangePassword.TabIndex = 10;
            btnChangePassword.Text = "Change my Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(71, 323);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 7;
            label3.Text = "New Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(71, 262);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 8;
            label2.Text = "E-mail adress:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 15F);
            label1.Location = new Point(84, 56);
            label1.Name = "label1";
            label1.Size = new Size(171, 24);
            label1.TabIndex = 9;
            label1.Text = "Change Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(70, 384);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 7;
            label4.Text = "Again New Password:";
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(69, 407);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(198, 23);
            txtPassword2.TabIndex = 11;
            // 
            // lblLinkLogin
            // 
            lblLinkLogin.AutoSize = true;
            lblLinkLogin.Location = new Point(22, 24);
            lblLinkLogin.Name = "lblLinkLogin";
            lblLinkLogin.Size = new Size(37, 15);
            lblLinkLogin.TabIndex = 16;
            lblLinkLogin.TabStop = true;
            lblLinkLogin.Text = "Login";
            lblLinkLogin.LinkClicked += lblLinkLogin_LinkClicked;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 638);
            Controls.Add(lblLinkLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword);
            Controls.Add(txtEmailAdress);
            Controls.Add(btnChangePassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkShowPassword;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private TextBox txtEmailAdress;
        private Button btnChangePassword;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtPassword2;
        private LinkLabel lblLinkLogin;
    }
}