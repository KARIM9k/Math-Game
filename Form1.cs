using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
        [Flags]
        public enum enOperation
        {
            enNone = 0, enAdd = 1, enSubtract = 2, enMultiply = 4, enDivide = 8
        }
        public enum enLevel
        {
            enEasy, enMedium, enHard, enRandomLevels
        }
        public enum enQuestionsType
        {
            enMultipleChoice, enTorF, enWriteAnswer
        }
        public struct stGameInfo
        {
            public enLevel Level;
            public enOperation Operation;
            public enQuestionsType QuestionsType;
            public int NumberOfRounds;
            public int NumberOfPlayers;
            public int TimeLimit;
            public int Player1Score;
            public int Player2Score;
        }
    public partial class Form1 : Form
    {       
        stGameInfo GameInfo;

        public Form1()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////

        void ChooseLevel(RadioButton radioButton)
        {
            lblLevelInfo.Text = radioButton.Text;
            GameInfo.Level = GetenLevelFromName(radioButton.Text);
        }
        enLevel GetenLevelFromName(string Level)
        {
            switch (Level)
            {
                case "Easy":
                    return enLevel.enEasy;
                case "Medium":
                    return enLevel.enMedium;
                case "Hard":
                    return enLevel.enHard;
                case "Random":
                    return enLevel.enRandomLevels;

            }
            return enLevel.enRandomLevels;
        }
        ///////////////////////////////////////////////////////////////////////
        void ChooseOperations()
        {
            GameInfo.Operation = enOperation.enNone;
            string sOperations = "";
            if (chkAddition.Checked)
            {
                GameInfo.Operation |= enOperation.enAdd;
                sOperations += ", A";
            }
            if (chkSubtraction.Checked)
            {
                GameInfo.Operation |= enOperation.enSubtract;
                sOperations += ", S";
            }
            if (chkMultiplication.Checked)
            {
                GameInfo.Operation |= enOperation.enMultiply;
                sOperations += ", M";
            }
            if (chkDivision.Checked)
            {
                GameInfo.Operation |= enOperation.enDivide;
                sOperations += ", D";
            }
            if (sOperations.StartsWith(","))
            {
                sOperations = sOperations.Substring(1, sOperations.Length - 1).Trim();
            }
            lblOpInfo.Text = string.IsNullOrEmpty(sOperations) ? "None" : sOperations;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        void ChooseNumberOfRounds(NumericUpDown numericUpDown)
        {
            lblRoundsNumberInfo.Text = numericUpDown.Value.ToString();
            GameInfo.NumberOfRounds = Convert.ToInt32(numericUpDown.Value);
        }
        ///////////////////////////////////////////////////////////////////////////
        void ChooseNumberOfPlayers(NumericUpDown numericUpDown)
        {
            lblPlayersNumberInfo.Text = numericUpDown.Value.ToString();
            GameInfo.NumberOfPlayers = Convert.ToInt32(numericUpDown.Value);
        }
        /////////////////////////////////////////////////////////////////////////////////////
        void ChooseTimeLimit(TrackBar trackBar)
        {
            lblTrackBarValue.Text = tbTimeLimit.Value + "s";
            lblTimeLimitInfo.Text = tbTimeLimit.Value + "s";
            GameInfo.TimeLimit = tbTimeLimit.Value;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        void ChooseQuestionsType(RadioButton radioButton)
        {
            lblQuestionsTypeInfo.Text = radioButton.Text;
            GameInfo.QuestionsType = GetQuestionsTypeFromName(radioButton.Text);
        }
        enQuestionsType GetQuestionsTypeFromName(string QuestionType)
        {
            switch (QuestionType)
            {
                case "Multiple Choice":
                    return enQuestionsType.enMultipleChoice;
                case "T/F":
                    return enQuestionsType.enTorF;
                case "Write Answer":
                    return enQuestionsType.enWriteAnswer;
            }
            return enQuestionsType.enWriteAnswer;
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        void ResetGameInfo()
        {
            nudNumberOfRounds.Value = 1;
            nudPlayersNumber.Value = 1;
            lblLevelInfo.Text = "";
            lblOpInfo.Text = "";
            lblQuestionsTypeInfo.Text = "";
            lblTimeLimitInfo.Text = "";
            lblTrackBarValue.Text = "0s";
            GameInfo.Level = enLevel.enEasy;
            GameInfo.NumberOfPlayers = 1;
            GameInfo.NumberOfRounds = 1;
            GameInfo.Operation = enOperation.enNone;
            GameInfo.QuestionsType = enQuestionsType.enMultipleChoice;
            GameInfo.TimeLimit = 5;
            rbEasy.Checked = false;
            rbMedium.Checked = false;
            rbHard.Checked = false;
            rbRandom.Checked = false;
            chkAddition.Checked = false;
            chkSubtraction.Checked = false;
            chkMultiplication.Checked = false;
            chkDivision.Checked = false;
            rbTorF.Checked = false;
            rbMultipleChoice.Checked = false;
            rbWriteAnswer.Checked = false;
            tbTimeLimit.Value = 5;
            

        }
        ////////////////////////////////////////////////////////////////////////////
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            ChooseLevel((RadioButton)sender);
        }

        private void rbMideum_CheckedChanged(object sender, EventArgs e)
        {
            ChooseLevel((RadioButton)sender);

        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            ChooseLevel((RadioButton)sender);

        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            ChooseLevel((RadioButton)sender);

        }

        private void cbAddition_CheckedChanged(object sender, EventArgs e)
        {
            ChooseOperations();
        }

        private void cbSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            ChooseOperations();

        }

        private void cbMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            ChooseOperations();

        }

        private void cbDivision_CheckedChanged(object sender, EventArgs e)
        {
            ChooseOperations();

        }

        private void nudNumberOfRounds_ValueChanged(object sender, EventArgs e)
        {
            ChooseNumberOfRounds((NumericUpDown)sender);
        }

        private void nudPlayersNumber_ValueChanged(object sender, EventArgs e)
        {
            ChooseNumberOfPlayers((NumericUpDown)sender);
        }
        private void tbTimeLimit_Scroll(object sender, EventArgs e)
        {
            ChooseTimeLimit((TrackBar)sender);
        }

        private void rbMultipleChoice_CheckedChanged(object sender, EventArgs e)
        {
            ChooseQuestionsType((RadioButton)sender);
        }

        private void rbTorF_CheckedChanged(object sender, EventArgs e)
        {
            ChooseQuestionsType((RadioButton)sender);

        }

        private void rbWriteAnswer_CheckedChanged(object sender, EventArgs e)
        {
            ChooseQuestionsType((RadioButton)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GameInfo.Operation == enOperation.enNone)
            {
                MessageBox.Show("Please select at least one operation!");
                return;
            }

            MessageBox.Show(
                $"Level: {GameInfo.Level}\n" +
                $"Operations: {GameInfo.Operation}\n" +
                $"Players: {GameInfo.NumberOfPlayers}\n" +
                $"Rounds: {GameInfo.NumberOfRounds}\n" +
                $"Time: {GameInfo.TimeLimit}s\n" +
                $"Question Type: {GameInfo.QuestionsType}"
            );
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            if(MessageBox.Show(
                $"Level: {lblLevelInfo.Text}\n" +
                $"Operations: {lblOpInfo.Text}\n" +
                $"Players: {GameInfo.NumberOfPlayers}\n" +
                $"Rounds: {GameInfo.NumberOfRounds}\n" +
                $"Time: {GameInfo.TimeLimit}s\n" +
                $"Question Type: {lblQuestionsTypeInfo.Text}",
                "Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question
            ) == DialogResult.OK)
            {
                switch (GameInfo.QuestionsType)
                {
                    case enQuestionsType.enMultipleChoice:
                        frm = new frmPlayMultipleChoice(GameInfo);
                        break;
                    case enQuestionsType.enTorF:
                        frm = new frmPlayTorF(GameInfo);
                        break;
                    case enQuestionsType.enWriteAnswer:
                        frm = new frmPlayWriteAnswer(GameInfo);
                        break;
                   
                }
            }
            else
            {
                MessageBox.Show("Its Canceled");
                return;
            }
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGameInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
