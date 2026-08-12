namespace Math_Game
{
    partial class frmPlayMultipleChoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.lblEquation = new System.Windows.Forms.Label();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Round:";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Mongolian Baiti", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.DimGray;
            this.lblRound.Location = new System.Drawing.Point(183, 38);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(237, 46);
            this.lblRound.TabIndex = 5;
            this.lblRound.Text = "Choose One";
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlayer2Score.Location = new System.Drawing.Point(299, 158);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer2Score.TabIndex = 13;
            this.lblPlayer2Score.Text = "0";
            this.lblPlayer2Score.Visible = false;
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlayer1Score.Location = new System.Drawing.Point(299, 103);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer1Score.TabIndex = 12;
            this.lblPlayer1Score.Text = "0";
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer2.ForeColor = System.Drawing.Color.DimGray;
            this.lblScorePlayer2.Location = new System.Drawing.Point(47, 158);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(121, 43);
            this.lblScorePlayer2.TabIndex = 11;
            this.lblScorePlayer2.Text = "Score:";
            this.lblScorePlayer2.Visible = false;
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.lblScorePlayer1.Location = new System.Drawing.Point(47, 103);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(121, 43);
            this.lblScorePlayer1.TabIndex = 10;
            this.lblScorePlayer1.Text = "Score:";
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Mongolian Baiti", 36F);
            this.lblEquation.ForeColor = System.Drawing.Color.DimGray;
            this.lblEquation.Location = new System.Drawing.Point(445, 103);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(293, 77);
            this.lblEquation.TabIndex = 14;
            this.lblEquation.Text = "Equation";
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnChoice1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.Location = new System.Drawing.Point(89, 218);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(220, 104);
            this.btnChoice1.TabIndex = 15;
            this.btnChoice1.Text = "Choice1";
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.AliceBlue;
            this.btnChoice2.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.Location = new System.Drawing.Point(409, 218);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(220, 104);
            this.btnChoice2.TabIndex = 16;
            this.btnChoice2.Text = "Choice2";
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.AliceBlue;
            this.btnChoice3.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice3.Location = new System.Drawing.Point(89, 334);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(220, 104);
            this.btnChoice3.TabIndex = 17;
            this.btnChoice3.Text = "Choice3";
            this.btnChoice3.UseVisualStyleBackColor = false;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // btnChoice4
            // 
            this.btnChoice4.BackColor = System.Drawing.Color.AliceBlue;
            this.btnChoice4.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice4.Location = new System.Drawing.Point(409, 334);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(220, 104);
            this.btnChoice4.TabIndex = 18;
            this.btnChoice4.Text = "Choice4";
            this.btnChoice4.UseVisualStyleBackColor = false;
            this.btnChoice4.Click += new System.EventHandler(this.btnChoice4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(702, 38);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 43);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "0s";
            // 
            // frmPlayMultipleChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(835, 497);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblScorePlayer2);
            this.Controls.Add(this.lblScorePlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRound);
            this.Name = "frmPlayMultipleChoice";
            this.Text = "Play Multiple Choice";
            this.Load += new System.EventHandler(this.frmPlayMultipleChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Label lblScorePlayer1;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}