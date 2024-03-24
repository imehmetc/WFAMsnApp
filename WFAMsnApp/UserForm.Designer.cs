namespace WFAMsnApp
{
    partial class UserForm
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
            label1 = new Label();
            lblUserName = new Label();
            txtMsjGonder = new TextBox();
            btnGonder = new Button();
            rtbMesajlar = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Hoşgeldin,";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(94, 29);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(40, 15);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "label2";
            // 
            // txtMsjGonder
            // 
            txtMsjGonder.BorderStyle = BorderStyle.FixedSingle;
            txtMsjGonder.Location = new Point(70, 314);
            txtMsjGonder.Multiline = true;
            txtMsjGonder.Name = "txtMsjGonder";
            txtMsjGonder.Size = new Size(575, 63);
            txtMsjGonder.TabIndex = 3;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(566, 323);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(75, 46);
            btnGonder.TabIndex = 4;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // rtbMesajlar
            // 
            rtbMesajlar.Enabled = false;
            rtbMesajlar.Location = new Point(70, 47);
            rtbMesajlar.Name = "rtbMesajlar";
            rtbMesajlar.Size = new Size(575, 261);
            rtbMesajlar.TabIndex = 5;
            rtbMesajlar.Text = "";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 404);
            Controls.Add(rtbMesajlar);
            Controls.Add(btnGonder);
            Controls.Add(txtMsjGonder);
            Controls.Add(lblUserName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUserName;
        private TextBox txtMsjGonder;
        private Button btnGonder;
        private RichTextBox rtbMesajlar;
    }
}