using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LearnMathWithMe
{
    public partial class MathTemplate : Form1
    {
        GenerateNumbers generateNumbers = new GenerateNumbers();

        int question = 0;
        int totalquestion = 5;
        int userInput;
        String math = MainMenu.selected;
        int count = 0;

        public MathTemplate()
        {
            InitializeComponent();
        }

        private void btnChkAnswer_Click(object sender, EventArgs e)
        {
            MathSelected();
           
            try
            {
                checkUserInput();
                userInput = Convert.ToInt32(txtAnswer.Text);

                if (count == 1)
                {
                    if (userInput == generateNumbers.result)
                    {
                        MessageBox.Show("Well done!!");
                        txtAnswer.Text = "";
                        addScore();
                        SetGenerateRandomNo();
                        count = 0;
                        question++;
                    }
                    else
                    {
                        MessageBox.Show("Wrong answer, try again");
                        txtAnswer.Text = "";
                        count++;

                    }
                }
            
                else if (count == 2)
                {
                    if (userInput == generateNumbers.result)
                    {
                        MessageBox.Show("Well done!!");
                        txtAnswer.Text = "";
                        addScore();
                        SetGenerateRandomNo();
                        count = 0;
                        question++;
                    }

                    else
                    {
                        MessageBox.Show("Wrong answer, move to next question");
                        txtAnswer.Text = "";
                        minusScore();
                        count = 0;
                        SetGenerateRandomNo();
                        question++;
                    }
                }

                else
                {
                    if (userInput == generateNumbers.result)
                    {
                        MessageBox.Show("Well done!!");
                        txtAnswer.Text = "";
                        addScore();
                        SetGenerateRandomNo();
                        question++;
                    }

                    else
                    {
                        MessageBox.Show("Wrong answer, try again");
                        txtAnswer.Text = "";
                        count++;
                    }
                }
            } catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                txtAnswer.Text = "";
            }
            CountQuestion();
        }

        private void MathTemplate_Load(object sender, EventArgs e)
        {
            MathSelected();
            SetGenerateRandomNo();
            Scores.operation = calculation.Text; //Set value of math operations
        }

        public void SetGenerateRandomNo()  //Set Generate Numbers to labels
        {        
            generateNumbers.GenerateRandomNo();
            labelFirst.Text = Convert.ToString(generateNumbers.firstNum);
            labelSecond.Text = Convert.ToString(generateNumbers.secondNum);
        }

        public void CountQuestion()  //count total number of questions
        {

            if (question == totalquestion)
            {
                labelLife.Text = "";
                txtAnswer.Enabled = false;
                Scores.score = Convert.ToInt32(labelScore.Text); //set value of score

                GameSetting gameSetting = new GameSetting();
                gameSetting.saveScoreReport(Scores.operation, Scores.date, Scores.score);

                MessageBox.Show("You answered all questions!!");

                this.Close();

                ScoreReport scoreReport = new ScoreReport();
                scoreReport.Show();
        
            }
            else if (question == 1)
            {
                labelLife.Text = "♥♥♥♥";
            }
            else if (question == 2)
            {
                labelLife.Text = "♥♥♥";
            }

            else if (question == 3)
            {
                labelLife.Text = "♥♥";
            }

            else if (question == 4)
            {
                labelLife.Text = "♥";
            }
        }

        public void addScore()  //Add score
        {
            int score = Convert.ToInt32(labelScore.Text) + 30;
            labelScore.Text = score.ToString();

        }

        public void minusScore()   //Minus score
        {
            int score = Convert.ToInt32(labelScore.Text) - 10;
            labelScore.Text = score.ToString();

        }

        public void MathSelected()   //Set value of each operation
        {

            if (math == "ADDITION")
            {
                title.Text = "Learn Addition";
                calculation.Text = "+";
                generateNumbers.Addition();

            }
            else if (math == "SUBTRACTION")
            {
                title.Text = "Learn Subtraction";
                calculation.Text = "-";
                generateNumbers.Subtraction();

            }
            else if (math == "MULTIPLICATION")
            {
                title.Text = "Learn Multiplication";
                calculation.Text = "x";
                generateNumbers.Multiplication();

            }
            else if (math == "DIVISION")
            {
                title.Text = "Learn Division";
                calculation.Text = "÷";
                generateNumbers.Division();
              
            }
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        public void checkUserInput() //Check value of txtAnswer
        {
            if (txtAnswer.Text == "")
            {
                throw new InvalidNumberException("Enter your answer");
            }

            else if (txtAnswer.Text.All(Char.IsLetter))
            {
                txtAnswer.Text = "";
                throw new InvalidNumberException("Enter only NUMBER");
            }
        }
    }
}
