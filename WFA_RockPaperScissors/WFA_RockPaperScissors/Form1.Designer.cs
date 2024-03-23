namespace WFA_RockPaperScissors
{
    partial class Form1
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
            btnScissors = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRock = new Button();
            btnPaper = new Button();
            btnLuck = new Button();
            pbResim = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            lblPlayerScore = new Label();
            lblPcScore = new Label();
            lblWin = new Label();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            SuspendLayout();
            // 
            // btnScissors
            // 
            btnScissors.Location = new Point(750, 268);
            btnScissors.Margin = new Padding(4);
            btnScissors.Name = "btnScissors";
            btnScissors.Size = new Size(216, 53);
            btnScissors.TabIndex = 0;
            btnScissors.Text = "Scissors";
            btnScissors.UseVisualStyleBackColor = true;
            btnScissors.Click += btnScissors_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(837, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 1;
            label1.Text = "You";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 1;
            label2.Text = "Bilgisayar";
            // 
            // btnRock
            // 
            btnRock.Location = new Point(750, 341);
            btnRock.Margin = new Padding(4);
            btnRock.Name = "btnRock";
            btnRock.Size = new Size(216, 53);
            btnRock.TabIndex = 0;
            btnRock.Text = "Rock";
            btnRock.UseVisualStyleBackColor = true;
            btnRock.Click += btnRock_Click;
            // 
            // btnPaper
            // 
            btnPaper.Location = new Point(750, 415);
            btnPaper.Margin = new Padding(4);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(216, 53);
            btnPaper.TabIndex = 0;
            btnPaper.Text = "Paper";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnLuck
            // 
            btnLuck.Location = new Point(750, 488);
            btnLuck.Margin = new Padding(4);
            btnLuck.Name = "btnLuck";
            btnLuck.Size = new Size(216, 53);
            btnLuck.TabIndex = 0;
            btnLuck.Text = "I feel lucky!";
            btnLuck.UseVisualStyleBackColor = true;
            btnLuck.Click += btnLuck_Click;
            // 
            // pbResim
            // 
            pbResim.Location = new Point(251, 84);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(435, 331);
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.TabIndex = 2;
            pbResim.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(821, 181);
            label10.Name = "label10";
            label10.Size = new Size(50, 19);
            label10.TabIndex = 3;
            label10.Text = "Skor: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 181);
            label11.Name = "label11";
            label11.Size = new Size(50, 19);
            label11.TabIndex = 3;
            label11.Text = "Skor: ";
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(877, 181);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(18, 19);
            lblPlayerScore.TabIndex = 4;
            lblPlayerScore.Text = "0";
            // 
            // lblPcScore
            // 
            lblPcScore.AutoSize = true;
            lblPcScore.Location = new Point(109, 181);
            lblPcScore.Name = "lblPcScore";
            lblPcScore.Size = new Size(18, 19);
            lblPcScore.TabIndex = 4;
            lblPcScore.Text = "0";
            // 
            // lblWin
            // 
            lblWin.BackColor = SystemColors.InactiveCaption;
            lblWin.BorderStyle = BorderStyle.FixedSingle;
            lblWin.Font = new Font("Bahnschrift", 15F);
            lblWin.ForeColor = SystemColors.ActiveCaptionText;
            lblWin.Location = new Point(251, 463);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(435, 78);
            lblWin.TabIndex = 5;
            lblWin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1031, 580);
            Controls.Add(lblWin);
            Controls.Add(lblPcScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pbResim);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLuck);
            Controls.Add(btnRock);
            Controls.Add(btnPaper);
            Controls.Add(btnScissors);
            Font = new Font("Bahnschrift", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnScissors;
        private Label label1;
        private Label label2;
        private Button btnRock;
        private Button btnPaper;
        private Button btnLuck;
        private PictureBox pbResim;
        private Label label10;
        private Label label11;
        private Label lblPlayerScore;
        private Label lblPcScore;
        private Label lblWin;
    }
}
