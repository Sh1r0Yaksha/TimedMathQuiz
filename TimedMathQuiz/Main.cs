using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class TimedMathQuiz : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;

        int subtractant1;
        int subtractant2;

        int multiplicant1;
        int multiplicant2;

        int divident1;
        int divident2;

        int timeLeft;

        public TimedMathQuiz()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            StartButton.Enabled = false;
            timeLeft = 30;
            TimeCounterLabel.Text = timeLeft + " seconds";
            Timer.Start();
            TimeCounterLabel.BackColor = Color.Empty;
        }
          
        private void StartQuiz()
        {
            addend1 = randomizer.Next(0, 100);
            addend2 = randomizer.Next(0, 100);
            subtractant1 = randomizer.Next(0, 100);
            subtractant2 = randomizer.Next(0, 100);
            multiplicant1 = randomizer.Next(1, 10);
            multiplicant2 = randomizer.Next(1, 10);
            divident2 = randomizer.Next(2, 15);
            int tempQuotient = randomizer.Next(2, 9);
            divident1 = divident2 * tempQuotient;  

            LeftOfPlusLabel.Text = addend1.ToString();
            RightOfPlusLabel.Text = addend2.ToString();

            LeftOfMinusLabel.Text = subtractant1.ToString();
            RightOfMinusLabel.Text = subtractant2.ToString();

            LeftOfMultiplyLabel.Text = multiplicant1.ToString();
            RightOfMultiplyLabel.Text = multiplicant2.ToString();

            LeftOfDivideLabel.Text = divident1.ToString();
            RightOfDivideLabel.Text= divident2.ToString();

            AdditionNumericUpDown.Value = 0;
            SubtractNumericUpDown.Value = 0;
            MultiplyNumericUpDown.Value = 0;
            DivideNumericUpDown.Value = 0;

            addCheckbox.Checked = false;
            subtractCheckbox.Checked = false;
            multiplyCheckbox.Checked = false;
            divideCheckbox.Checked = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CheckAnswers())
            {
                TickCheckboxes();
                Timer.Stop();
                MessageBox.Show("You got all answers right, congratulations!");
                TimeCounterLabel.Text = "";
                StartButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                TickCheckboxes();
                timeLeft -= 1;
                TimeCounterLabel.Text = timeLeft + " seconds";
                if (timeLeft < 10)
                    TimeCounterLabel.BackColor = Color.Red;
            }
            else
            {
                Timer.Stop();TimeCounterLabel.Text = "Time's up!";
                AdditionNumericUpDown.Value = addend1 + addend2;
                SubtractNumericUpDown.Value = subtractant1 - subtractant2;
                MultiplyNumericUpDown.Value = multiplicant1 * multiplicant2;
                DivideNumericUpDown.Value = divident1 / divident2;
                MessageBox.Show("You didn't finish in time, Sorry!");
                StartButton.Enabled = true;
            }
        }

        private bool CheckAnswers()
        {
            if (addend1 + addend2 == AdditionNumericUpDown.Value &&
                subtractant1 - subtractant2 == SubtractNumericUpDown.Value && 
                multiplicant1 * multiplicant2 == MultiplyNumericUpDown.Value &&
                divident1 / divident2 == DivideNumericUpDown.Value)
                return true;
            else
                return false;
        }

        private void TickCheckboxes()
        {
            if (addend1 + addend2 == AdditionNumericUpDown.Value)
            {
                addCheckbox.Checked = true;
                
            }
            if (subtractant1 - subtractant2 == SubtractNumericUpDown.Value)
            {
                subtractCheckbox.Checked = true;
            }
            if (multiplicant1 * multiplicant2 == MultiplyNumericUpDown.Value)
            {
                multiplyCheckbox.Checked = true;
            }
            if (divident1 / divident2 == DivideNumericUpDown.Value)
            {
                divideCheckbox.Checked = true;
            }
        }

        private void AnswerEnter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void CancelButtonClick(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "close application", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
