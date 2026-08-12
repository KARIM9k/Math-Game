namespace Math_Game
{
    partial class frmPlayTorF
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
            this.components = new System.ComponentModel.Container();
            this.lblEquation = new System.Windows.Forms.Label();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Mongolian Baiti", 36F);
            this.lblEquation.ForeColor = System.Drawing.Color.DimGray;
            this.lblEquation.Location = new System.Drawing.Point(390, 75);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(293, 77);
            this.lblEquation.TabIndex = 0;
            this.lblEquation.Text = "Equation";
            // 
            // btnTrue
            // 
            this.btnTrue.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTrue.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(403, 185);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(220, 104);
            this.btnTrue.TabIndex = 1;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = false;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // btnFalse
            // 
            this.btnFalse.BackColor = System.Drawing.Color.AliceBlue;
            this.btnFalse.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalse.Location = new System.Drawing.Point(403, 316);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(220, 104);
            this.btnFalse.TabIndex = 2;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = false;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.DimGray;
            this.lblRound.Location = new System.Drawing.Point(167, 33);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(237, 46);
            this.lblRound.TabIndex = 3;
            this.lblRound.Text = "Choose One";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Round:";
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.lblScorePlayer1.Location = new System.Drawing.Point(40, 145);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(121, 43);
            this.lblScorePlayer1.TabIndex = 6;
            this.lblScorePlayer1.Text = "Score:";
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer2.ForeColor = System.Drawing.Color.DimGray;
            this.lblScorePlayer2.Location = new System.Drawing.Point(40, 271);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(121, 43);
            this.lblScorePlayer2.TabIndex = 7;
            this.lblScorePlayer2.Text = "Score:";
            this.lblScorePlayer2.Visible = false;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlayer1Score.Location = new System.Drawing.Point(292, 145);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer1Score.TabIndex = 8;
            this.lblPlayer1Score.Text = "0";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlayer2Score.Location = new System.Drawing.Point(292, 271);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer2Score.TabIndex = 9;
            this.lblPlayer2Score.Text = "0";
            this.lblPlayer2Score.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(670, 32);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 43);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "0s";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPlayTorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblScorePlayer2);
            this.Controls.Add(this.lblScorePlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.lblEquation);
            this.Name = "frmPlayTorF";
            this.Text = "Play T/F";
            this.Load += new System.EventHandler(this.frmPlayTorF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScorePlayer1;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}