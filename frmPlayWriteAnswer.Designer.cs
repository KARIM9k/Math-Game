namespace Math_Game
{
    partial class frmPlayWriteAnswer
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
            this.lblEquation = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Round:";
            this.label1.Click += new System.EventHandler(this.lblEquation_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEquation.Location = new System.Drawing.Point(472, 103);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(293, 77);
            this.lblEquation.TabIndex = 1;
            this.lblEquation.Text = "Equation";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.AliceBlue;
            this.btnStart.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(475, 306);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(285, 98);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Next";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.DimGray;
            this.lblRound.Location = new System.Drawing.Point(167, 30);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(189, 43);
            this.lblRound.TabIndex = 3;
            this.lblRound.Text = "Press Start";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(480, 236);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(285, 26);
            this.txtAnswer.TabIndex = 4;
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer1.ForeColor = System.Drawing.Color.DimGray;
            this.lblScorePlayer1.Location = new System.Drawing.Point(24, 131);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(121, 43);
            this.lblScorePlayer1.TabIndex = 5;
            this.lblScorePlayer1.Text = "Score:";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlayer1Score.Location = new System.Drawing.Point(303, 131);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer1Score.TabIndex = 6;
            this.lblPlayer1Score.Text = "0";
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScorePlayer2.ForeColor = System.Drawing.Color.DimGray;
            this.lblScorePlayer2.Location = new System.Drawing.Point(24, 247);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(121, 43);
            this.lblScorePlayer2.TabIndex = 7;
            this.lblScorePlayer2.Text = "Score:";
            this.lblScorePlayer2.Visible = false;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlayer2Score.Location = new System.Drawing.Point(303, 247);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(39, 43);
            this.lblPlayer2Score.TabIndex = 8;
            this.lblPlayer2Score.Text = "0";
            this.lblPlayer2Score.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(655, 30);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(55, 43);
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "0s";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPlayWriteAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.lblScorePlayer2);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblScorePlayer1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.label1);
            this.Name = "frmPlayWriteAnswer";
            this.Text = "Play Write Answer";
            this.Load += new System.EventHandler(this.frmPlayWriteAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblScorePlayer1;
        private System.Windows.Forms.Label lblPlayer1Score;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}