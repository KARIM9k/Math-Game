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
    public partial class frmPlayTorF : Form
    {
        private stGameInfo _gameInfo;
        private int _currentRound = 1;
        private int _currentPlayer = 1;
        private int _displayedAnswer = 0;
        private int TimeCounter = 0;
        public frmPlayTorF(stGameInfo gameInfo)
        {
            InitializeComponent();
            _gameInfo = gameInfo;
        }
        struct stEquation
        {
            public int Number1;
            public int Number2;
            public int Answer;
            public bool PlayerAnswer;
            public enOperation Op;
        }
        private stEquation Equation;
        private Random random = new Random();

        int GetRandomNumber()
        {
            int LowerBound = 1;
            int UpperBound = 10;
            switch (_gameInfo.Level)
            {
                case enLevel.enEasy:
                    LowerBound = 1;
                    UpperBound = 10;
                    break;
                case enLevel.enMedium:
                    LowerBound = 10;
                    UpperBound = 50;
                    break;
                case enLevel.enHard:
                    LowerBound = 50;
                    UpperBound = 200;
                    break;
                case enLevel.enRandomLevels:
                    int randomLevel = random.Next(1, 4);
                    if (randomLevel == 1) { LowerBound = 1; UpperBound = 10; }
                    else if (randomLevel == 2) { LowerBound = 10; UpperBound = 50; }
                    else { LowerBound = 50; UpperBound = 200; }
                    break;
            }
            return random.Next(LowerBound, UpperBound + 1);
        }
        enOperation GetOperation()
        {
            List<enOperation> activeOperations = new List<enOperation>();
            if (_gameInfo.Operation.HasFlag(enOperation.enAdd))
                activeOperations.Add(enOperation.enAdd);
            if (_gameInfo.Operation.HasFlag(enOperation.enSubtract))
                activeOperations.Add(enOperation.enSubtract);
            if (_gameInfo.Operation.HasFlag(enOperation.enMultiply))
                activeOperations.Add(enOperation.enMultiply);
            if (_gameInfo.Operation.HasFlag(enOperation.enDivide))
                activeOperations.Add(enOperation.enDivide);
            int idx = random.Next(activeOperations.Count);
            return activeOperations[idx];
        }
        string GetOpSymbol(enOperation op)
        {
            switch (op)
            {
                case enOperation.enAdd: return "+";
                case enOperation.enSubtract: return "-";
                case enOperation.enMultiply: return "x";
                case enOperation.enDivide: return "÷";
                default: return "";
            }
        }
        void GetEquation()
        {
            Equation.Number1 = GetRandomNumber();
            Equation.Number2 = GetRandomNumber();
            Equation.Op = GetOperation();
            if (Equation.Op == enOperation.enDivide)
            {
                List<int> factors = new List<int>();
                for (int i = 1; i <= Equation.Number1; i++)
                {
                    if (Equation.Number1 % i == 0)
                        factors.Add(i);
                }
                Equation.Number2 = factors[random.Next(factors.Count)];
            }
            Equation.Answer = GetAnswer();

        }
        int GetAnswer()
        {
            int Number1 = Equation.Number1;
            int Number2 = Equation.Number2;
            switch (Equation.Op)
            {
                case enOperation.enNone:
                    return 0;
                case enOperation.enAdd:
                    return Number1 + Number2;
                case enOperation.enSubtract:
                    return Number1 - Number2;
                case enOperation.enMultiply:
                    return Number1 * Number2;
                case enOperation.enDivide:
                    if (Number2 != 0)
                    {
                        return Number1 / Number2;
                    }
                    else
                    {
                        return 0;
                    }
                default:
                    return 0;
            }
        }

        int GetWrongAnswer()
        {
            int WrongAnswer;
            do
            {
                int diff = random.Next(1, 6);
                WrongAnswer = (random.Next(0, 2) == 0) ? Equation.Answer + diff : Equation.Answer - diff;
            } while (WrongAnswer == Equation.Answer);

            return WrongAnswer;
        }
        void StartRound()
        {

            timer1.Stop();
            TimeCounter = 0;
            lblTime.Text = $"{TimeCounter}s / {_gameInfo.TimeLimit}s";
            timer1.Start();
            if (_gameInfo.NumberOfPlayers == 2)
            {
                lblRound.Text = $"{_currentRound}/{_gameInfo.NumberOfRounds} - Player {_currentPlayer}'s Turn";
                lblScorePlayer1.Text = "Player1 Score:";
                lblScorePlayer2.Visible = true;
                lblPlayer2Score.Visible = true;
                lblScorePlayer2.Text = "Player2 Score:";
            }
            else
            {
                lblRound.Text = $"{_currentRound}/{_gameInfo.NumberOfRounds}";

            }
            GetEquation();
            //The Answer Will be in Range Answer+5 and Answer-5
            bool isCorrectShown = random.Next(0, 2)==1;

            if (isCorrectShown)
            {
                _displayedAnswer = Equation.Answer;
            }
            else
            {
                _displayedAnswer = GetWrongAnswer();
            }
            lblEquation.Text = $"{Equation.Number1} {GetOpSymbol(Equation.Op)} {Equation.Number2} = {_displayedAnswer}";
        }

        void ProcessUserAnswer(bool playerSelectedTrue)
        {

            timer1.Stop();

            Equation.PlayerAnswer = playerSelectedTrue;
            bool isCorrect = (Equation.PlayerAnswer == (_displayedAnswer == Equation.Answer));


            if (TimeCounter >= _gameInfo.TimeLimit)
            {
                MessageBox.Show($"Time's Up! ❌\nCorrect answer was: {Equation.Answer}", "Time Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isCorrect)
            {
                if (_currentPlayer == 1)
                {
                    _gameInfo.Player1Score++;
                    lblPlayer1Score.Text = _gameInfo.Player1Score.ToString();
                }
                else
                {
                    _gameInfo.Player2Score++;
                    lblPlayer2Score.Text = _gameInfo.Player2Score.ToString();
                }
                MessageBox.Show("The Answer is Correct! 🎉", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"Wrong Answer ❌\nCorrect answer was: {Equation.Answer}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_gameInfo.NumberOfPlayers == 2)
            {
                if (_currentPlayer == 1)
                {
                    _currentPlayer = 2;
                    StartRound();
                    return;
                }
                else
                {
                    _currentPlayer = 1;
                    _currentRound++;
                }
            }
            else
            {
                _currentRound++;
            }
            if (_currentRound <= _gameInfo.NumberOfRounds)
            {
                StartRound();
            }
            else
            {
                EndGame();
            }

        }

        private void frmPlayTorF_Load(object sender, EventArgs e)
        {
            StartRound();
        }
        void EndGame()
        {
            string resultMessage = "";

            if (_gameInfo.NumberOfPlayers == 2)
            {
                resultMessage = $"Game Over!\n\nPlayer 1 Score: {_gameInfo.Player1Score}\nPlayer 2 Score: {_gameInfo.Player2Score}\n\n";

                if (_gameInfo.Player1Score > _gameInfo.Player2Score)
                    resultMessage += "🏆 Player 1 Wins!";
                else if (_gameInfo.Player2Score > _gameInfo.Player1Score)
                    resultMessage += "🏆 Player 2 Wins!";
                else
                    resultMessage += "🤝 It's a Tie!";
            }
            else
            {
                resultMessage = $"Game Over!\nYour Score: {_gameInfo.Player1Score} / {_gameInfo.NumberOfRounds}";
            }

            MessageBox.Show(resultMessage, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            ProcessUserAnswer(true);
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            ProcessUserAnswer(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeCounter++;
            lblTime.Text = TimeCounter.ToString() + "s / " + _gameInfo.TimeLimit + 's';
            if (TimeCounter >= _gameInfo.TimeLimit)
            {
                ProcessUserAnswer(false);
            }
        }
    }
}
