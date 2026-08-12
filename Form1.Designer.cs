namespace Math_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbLevel = new System.Windows.Forms.GroupBox();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.gbRounds = new System.Windows.Forms.GroupBox();
            this.nudNumberOfRounds = new System.Windows.Forms.NumericUpDown();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.chkDivision = new System.Windows.Forms.CheckBox();
            this.chkMultiplication = new System.Windows.Forms.CheckBox();
            this.chkSubtraction = new System.Windows.Forms.CheckBox();
            this.chkAddition = new System.Windows.Forms.CheckBox();
            this.gbPlayersNumber = new System.Windows.Forms.GroupBox();
            this.nudPlayersNumber = new System.Windows.Forms.NumericUpDown();
            this.gbTimeLimit = new System.Windows.Forms.GroupBox();
            this.lblTrackBarValue = new System.Windows.Forms.Label();
            this.tbTimeLimit = new System.Windows.Forms.TrackBar();
            this.gbQuestionsType = new System.Windows.Forms.GroupBox();
            this.rbWriteAnswer = new System.Windows.Forms.RadioButton();
            this.rbTorF = new System.Windows.Forms.RadioButton();
            this.rbMultipleChoice = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbSittingList = new System.Windows.Forms.GroupBox();
            this.lblQuestionsTypeInfo = new System.Windows.Forms.Label();
            this.lblTimeLimitInfo = new System.Windows.Forms.Label();
            this.lblPlayersNumberInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRoundsNumberInfo = new System.Windows.Forms.Label();
            this.lblOpInfo = new System.Windows.Forms.Label();
            this.lblLevelInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLevel.SuspendLayout();
            this.gbRounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRounds)).BeginInit();
            this.gbOperations.SuspendLayout();
            this.gbPlayersNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayersNumber)).BeginInit();
            this.gbTimeLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLimit)).BeginInit();
            this.gbQuestionsType.SuspendLayout();
            this.gbSittingList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTitle.Location = new System.Drawing.Point(333, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 77);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Math Game";
            // 
            // gbLevel
            // 
            this.gbLevel.Controls.Add(this.rbRandom);
            this.gbLevel.Controls.Add(this.rbEasy);
            this.gbLevel.Controls.Add(this.rbHard);
            this.gbLevel.Controls.Add(this.rbMedium);
            this.gbLevel.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLevel.ForeColor = System.Drawing.Color.Gold;
            this.gbLevel.Location = new System.Drawing.Point(36, 111);
            this.gbLevel.Name = "gbLevel";
            this.gbLevel.Size = new System.Drawing.Size(193, 233);
            this.gbLevel.TabIndex = 1;
            this.gbLevel.TabStop = false;
            this.gbLevel.Text = "Level";
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.ForeColor = System.Drawing.Color.DimGray;
            this.rbRandom.Location = new System.Drawing.Point(18, 165);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(110, 28);
            this.rbRandom.TabIndex = 5;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.ForeColor = System.Drawing.Color.DimGray;
            this.rbEasy.Location = new System.Drawing.Point(18, 42);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(78, 28);
            this.rbEasy.TabIndex = 4;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.ForeColor = System.Drawing.Color.DimGray;
            this.rbHard.Location = new System.Drawing.Point(18, 124);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(79, 28);
            this.rbHard.TabIndex = 6;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.ForeColor = System.Drawing.Color.DimGray;
            this.rbMedium.Location = new System.Drawing.Point(18, 83);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(110, 28);
            this.rbMedium.TabIndex = 3;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMideum_CheckedChanged);
            // 
            // gbRounds
            // 
            this.gbRounds.Controls.Add(this.nudNumberOfRounds);
            this.gbRounds.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRounds.ForeColor = System.Drawing.Color.Gold;
            this.gbRounds.Location = new System.Drawing.Point(36, 360);
            this.gbRounds.Name = "gbRounds";
            this.gbRounds.Size = new System.Drawing.Size(193, 142);
            this.gbRounds.TabIndex = 7;
            this.gbRounds.TabStop = false;
            this.gbRounds.Text = "Number Of Rounds";
            // 
            // nudNumberOfRounds
            // 
            this.nudNumberOfRounds.Location = new System.Drawing.Point(18, 71);
            this.nudNumberOfRounds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfRounds.Name = "nudNumberOfRounds";
            this.nudNumberOfRounds.Size = new System.Drawing.Size(110, 33);
            this.nudNumberOfRounds.TabIndex = 8;
            this.nudNumberOfRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfRounds.ValueChanged += new System.EventHandler(this.nudNumberOfRounds_ValueChanged);
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.chkDivision);
            this.gbOperations.Controls.Add(this.chkMultiplication);
            this.gbOperations.Controls.Add(this.chkSubtraction);
            this.gbOperations.Controls.Add(this.chkAddition);
            this.gbOperations.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperations.ForeColor = System.Drawing.Color.Gold;
            this.gbOperations.Location = new System.Drawing.Point(251, 119);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(216, 225);
            this.gbOperations.TabIndex = 9;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // chkDivision
            // 
            this.chkDivision.AutoSize = true;
            this.chkDivision.ForeColor = System.Drawing.Color.DimGray;
            this.chkDivision.Location = new System.Drawing.Point(14, 155);
            this.chkDivision.Name = "chkDivision";
            this.chkDivision.Size = new System.Drawing.Size(112, 28);
            this.chkDivision.TabIndex = 3;
            this.chkDivision.Text = "Division";
            this.chkDivision.UseVisualStyleBackColor = true;
            this.chkDivision.CheckedChanged += new System.EventHandler(this.cbDivision_CheckedChanged);
            // 
            // chkMultiplication
            // 
            this.chkMultiplication.AutoSize = true;
            this.chkMultiplication.ForeColor = System.Drawing.Color.DimGray;
            this.chkMultiplication.Location = new System.Drawing.Point(14, 115);
            this.chkMultiplication.Name = "chkMultiplication";
            this.chkMultiplication.Size = new System.Drawing.Size(162, 28);
            this.chkMultiplication.TabIndex = 2;
            this.chkMultiplication.Text = "Multiplication";
            this.chkMultiplication.UseVisualStyleBackColor = true;
            this.chkMultiplication.CheckedChanged += new System.EventHandler(this.cbMultiplication_CheckedChanged);
            // 
            // chkSubtraction
            // 
            this.chkSubtraction.AutoSize = true;
            this.chkSubtraction.ForeColor = System.Drawing.Color.DimGray;
            this.chkSubtraction.Location = new System.Drawing.Point(14, 76);
            this.chkSubtraction.Name = "chkSubtraction";
            this.chkSubtraction.Size = new System.Drawing.Size(137, 28);
            this.chkSubtraction.TabIndex = 1;
            this.chkSubtraction.Text = "Subtraction";
            this.chkSubtraction.UseVisualStyleBackColor = true;
            this.chkSubtraction.CheckedChanged += new System.EventHandler(this.cbSubtraction_CheckedChanged);
            // 
            // chkAddition
            // 
            this.chkAddition.AutoSize = true;
            this.chkAddition.ForeColor = System.Drawing.Color.DimGray;
            this.chkAddition.Location = new System.Drawing.Point(14, 42);
            this.chkAddition.Name = "chkAddition";
            this.chkAddition.Size = new System.Drawing.Size(114, 28);
            this.chkAddition.TabIndex = 0;
            this.chkAddition.Text = "Addition";
            this.chkAddition.UseVisualStyleBackColor = true;
            this.chkAddition.CheckedChanged += new System.EventHandler(this.cbAddition_CheckedChanged);
            // 
            // gbPlayersNumber
            // 
            this.gbPlayersNumber.Controls.Add(this.nudPlayersNumber);
            this.gbPlayersNumber.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayersNumber.ForeColor = System.Drawing.Color.Gold;
            this.gbPlayersNumber.Location = new System.Drawing.Point(251, 360);
            this.gbPlayersNumber.Name = "gbPlayersNumber";
            this.gbPlayersNumber.Size = new System.Drawing.Size(216, 142);
            this.gbPlayersNumber.TabIndex = 9;
            this.gbPlayersNumber.TabStop = false;
            this.gbPlayersNumber.Text = "Number Of Players";
            // 
            // nudPlayersNumber
            // 
            this.nudPlayersNumber.Location = new System.Drawing.Point(18, 71);
            this.nudPlayersNumber.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPlayersNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayersNumber.Name = "nudPlayersNumber";
            this.nudPlayersNumber.Size = new System.Drawing.Size(133, 33);
            this.nudPlayersNumber.TabIndex = 8;
            this.nudPlayersNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPlayersNumber.ValueChanged += new System.EventHandler(this.nudPlayersNumber_ValueChanged);
            // 
            // gbTimeLimit
            // 
            this.gbTimeLimit.Controls.Add(this.lblTrackBarValue);
            this.gbTimeLimit.Controls.Add(this.tbTimeLimit);
            this.gbTimeLimit.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimeLimit.ForeColor = System.Drawing.Color.Gold;
            this.gbTimeLimit.Location = new System.Drawing.Point(482, 119);
            this.gbTimeLimit.Name = "gbTimeLimit";
            this.gbTimeLimit.Size = new System.Drawing.Size(216, 181);
            this.gbTimeLimit.TabIndex = 10;
            this.gbTimeLimit.TabStop = false;
            this.gbTimeLimit.Text = "Time Limit";
            // 
            // lblTrackBarValue
            // 
            this.lblTrackBarValue.AutoSize = true;
            this.lblTrackBarValue.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrackBarValue.Location = new System.Drawing.Point(83, 119);
            this.lblTrackBarValue.Name = "lblTrackBarValue";
            this.lblTrackBarValue.Size = new System.Drawing.Size(35, 24);
            this.lblTrackBarValue.TabIndex = 2;
            this.lblTrackBarValue.Text = "Os";
            // 
            // tbTimeLimit
            // 
            this.tbTimeLimit.Location = new System.Drawing.Point(24, 56);
            this.tbTimeLimit.Maximum = 60;
            this.tbTimeLimit.Minimum = 5;
            this.tbTimeLimit.Name = "tbTimeLimit";
            this.tbTimeLimit.Size = new System.Drawing.Size(156, 69);
            this.tbTimeLimit.SmallChange = 5;
            this.tbTimeLimit.TabIndex = 0;
            this.tbTimeLimit.Value = 5;
            this.tbTimeLimit.Scroll += new System.EventHandler(this.tbTimeLimit_Scroll);
            // 
            // gbQuestionsType
            // 
            this.gbQuestionsType.Controls.Add(this.rbWriteAnswer);
            this.gbQuestionsType.Controls.Add(this.rbTorF);
            this.gbQuestionsType.Controls.Add(this.rbMultipleChoice);
            this.gbQuestionsType.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestionsType.ForeColor = System.Drawing.Color.Gold;
            this.gbQuestionsType.Location = new System.Drawing.Point(482, 318);
            this.gbQuestionsType.Name = "gbQuestionsType";
            this.gbQuestionsType.Size = new System.Drawing.Size(216, 184);
            this.gbQuestionsType.TabIndex = 11;
            this.gbQuestionsType.TabStop = false;
            this.gbQuestionsType.Text = "Questions Type";
            // 
            // rbWriteAnswer
            // 
            this.rbWriteAnswer.AutoSize = true;
            this.rbWriteAnswer.ForeColor = System.Drawing.Color.DimGray;
            this.rbWriteAnswer.Location = new System.Drawing.Point(30, 128);
            this.rbWriteAnswer.Name = "rbWriteAnswer";
            this.rbWriteAnswer.Size = new System.Drawing.Size(160, 28);
            this.rbWriteAnswer.TabIndex = 7;
            this.rbWriteAnswer.Text = "Write Answer";
            this.rbWriteAnswer.UseVisualStyleBackColor = true;
            this.rbWriteAnswer.CheckedChanged += new System.EventHandler(this.rbWriteAnswer_CheckedChanged);
            // 
            // rbTorF
            // 
            this.rbTorF.AutoSize = true;
            this.rbTorF.ForeColor = System.Drawing.Color.DimGray;
            this.rbTorF.Location = new System.Drawing.Point(30, 84);
            this.rbTorF.Name = "rbTorF";
            this.rbTorF.Size = new System.Drawing.Size(66, 28);
            this.rbTorF.TabIndex = 6;
            this.rbTorF.Text = "T/F";
            this.rbTorF.UseVisualStyleBackColor = true;
            this.rbTorF.CheckedChanged += new System.EventHandler(this.rbTorF_CheckedChanged);
            // 
            // rbMultipleChoice
            // 
            this.rbMultipleChoice.AutoSize = true;
            this.rbMultipleChoice.ForeColor = System.Drawing.Color.DimGray;
            this.rbMultipleChoice.Location = new System.Drawing.Point(30, 37);
            this.rbMultipleChoice.Name = "rbMultipleChoice";
            this.rbMultipleChoice.Size = new System.Drawing.Size(180, 28);
            this.rbMultipleChoice.TabIndex = 5;
            this.rbMultipleChoice.Text = "Multiple Choice";
            this.rbMultipleChoice.UseVisualStyleBackColor = true;
            this.rbMultipleChoice.CheckedChanged += new System.EventHandler(this.rbMultipleChoice_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Ivory;
            this.btnPlay.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.DimGray;
            this.btnPlay.Location = new System.Drawing.Point(714, 407);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(155, 87);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Ivory;
            this.btnReset.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DimGray;
            this.btnReset.Location = new System.Drawing.Point(889, 407);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 87);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbSittingList
            // 
            this.gbSittingList.Controls.Add(this.lblQuestionsTypeInfo);
            this.gbSittingList.Controls.Add(this.lblTimeLimitInfo);
            this.gbSittingList.Controls.Add(this.lblPlayersNumberInfo);
            this.gbSittingList.Controls.Add(this.label9);
            this.gbSittingList.Controls.Add(this.label8);
            this.gbSittingList.Controls.Add(this.label7);
            this.gbSittingList.Controls.Add(this.lblRoundsNumberInfo);
            this.gbSittingList.Controls.Add(this.lblOpInfo);
            this.gbSittingList.Controls.Add(this.lblLevelInfo);
            this.gbSittingList.Controls.Add(this.label3);
            this.gbSittingList.Controls.Add(this.label2);
            this.gbSittingList.Controls.Add(this.label1);
            this.gbSittingList.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSittingList.ForeColor = System.Drawing.Color.Gold;
            this.gbSittingList.Location = new System.Drawing.Point(714, 119);
            this.gbSittingList.Name = "gbSittingList";
            this.gbSittingList.Size = new System.Drawing.Size(311, 269);
            this.gbSittingList.TabIndex = 11;
            this.gbSittingList.TabStop = false;
            this.gbSittingList.Text = "Settings List";
            // 
            // lblQuestionsTypeInfo
            // 
            this.lblQuestionsTypeInfo.AutoSize = true;
            this.lblQuestionsTypeInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuestionsTypeInfo.Location = new System.Drawing.Point(198, 199);
            this.lblQuestionsTypeInfo.Name = "lblQuestionsTypeInfo";
            this.lblQuestionsTypeInfo.Size = new System.Drawing.Size(0, 24);
            this.lblQuestionsTypeInfo.TabIndex = 14;
            // 
            // lblTimeLimitInfo
            // 
            this.lblTimeLimitInfo.AutoSize = true;
            this.lblTimeLimitInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTimeLimitInfo.Location = new System.Drawing.Point(198, 167);
            this.lblTimeLimitInfo.Name = "lblTimeLimitInfo";
            this.lblTimeLimitInfo.Size = new System.Drawing.Size(0, 24);
            this.lblTimeLimitInfo.TabIndex = 13;
            // 
            // lblPlayersNumberInfo
            // 
            this.lblPlayersNumberInfo.AutoSize = true;
            this.lblPlayersNumberInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlayersNumberInfo.Location = new System.Drawing.Point(198, 131);
            this.lblPlayersNumberInfo.Name = "lblPlayersNumberInfo";
            this.lblPlayersNumberInfo.Size = new System.Drawing.Size(21, 24);
            this.lblPlayersNumberInfo.TabIndex = 12;
            this.lblPlayersNumberInfo.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(24, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "Questions Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(24, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Time Limit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(24, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Players Number:";
            // 
            // lblRoundsNumberInfo
            // 
            this.lblRoundsNumberInfo.AutoSize = true;
            this.lblRoundsNumberInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblRoundsNumberInfo.Location = new System.Drawing.Point(198, 97);
            this.lblRoundsNumberInfo.Name = "lblRoundsNumberInfo";
            this.lblRoundsNumberInfo.Size = new System.Drawing.Size(21, 24);
            this.lblRoundsNumberInfo.TabIndex = 8;
            this.lblRoundsNumberInfo.Text = "1";
            // 
            // lblOpInfo
            // 
            this.lblOpInfo.AutoSize = true;
            this.lblOpInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblOpInfo.Location = new System.Drawing.Point(198, 63);
            this.lblOpInfo.Name = "lblOpInfo";
            this.lblOpInfo.Size = new System.Drawing.Size(0, 24);
            this.lblOpInfo.TabIndex = 7;
            // 
            // lblLevelInfo
            // 
            this.lblLevelInfo.AutoSize = true;
            this.lblLevelInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblLevelInfo.Location = new System.Drawing.Point(198, 29);
            this.lblLevelInfo.Name = "lblLevelInfo";
            this.lblLevelInfo.Size = new System.Drawing.Size(0, 24);
            this.lblLevelInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rounds Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operations:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Level:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1037, 531);
            this.Controls.Add(this.gbSittingList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.gbQuestionsType);
            this.Controls.Add(this.gbTimeLimit);
            this.Controls.Add(this.gbPlayersNumber);
            this.Controls.Add(this.gbOperations);
            this.Controls.Add(this.gbRounds);
            this.Controls.Add(this.gbLevel);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLevel.ResumeLayout(false);
            this.gbLevel.PerformLayout();
            this.gbRounds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfRounds)).EndInit();
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            this.gbPlayersNumber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayersNumber)).EndInit();
            this.gbTimeLimit.ResumeLayout(false);
            this.gbTimeLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLimit)).EndInit();
            this.gbQuestionsType.ResumeLayout(false);
            this.gbQuestionsType.PerformLayout();
            this.gbSittingList.ResumeLayout(false);
            this.gbSittingList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbLevel;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.GroupBox gbRounds;
        private System.Windows.Forms.NumericUpDown nudNumberOfRounds;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.CheckBox chkDivision;
        private System.Windows.Forms.CheckBox chkMultiplication;
        private System.Windows.Forms.CheckBox chkSubtraction;
        private System.Windows.Forms.CheckBox chkAddition;
        private System.Windows.Forms.GroupBox gbPlayersNumber;
        private System.Windows.Forms.NumericUpDown nudPlayersNumber;
        private System.Windows.Forms.GroupBox gbTimeLimit;
        private System.Windows.Forms.TrackBar tbTimeLimit;
        private System.Windows.Forms.Label lblTrackBarValue;
        private System.Windows.Forms.GroupBox gbQuestionsType;
        private System.Windows.Forms.RadioButton rbWriteAnswer;
        private System.Windows.Forms.RadioButton rbTorF;
        private System.Windows.Forms.RadioButton rbMultipleChoice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gbSittingList;
        private System.Windows.Forms.Label lblRoundsNumberInfo;
        private System.Windows.Forms.Label lblOpInfo;
        private System.Windows.Forms.Label lblLevelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuestionsTypeInfo;
        private System.Windows.Forms.Label lblTimeLimitInfo;
        private System.Windows.Forms.Label lblPlayersNumberInfo;
        private System.Windows.Forms.Label label9;
    }
}

