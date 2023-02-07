using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniyIdiot.Common;


namespace GeniyIdiotWinFormsApp
{
    public partial class mainForm : Form     
    {
        Game game;
        int userAnswer;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomForm = new WelcomForm();
            welcomForm.ShowDialog();

            var user = new User(welcomForm.userNameTextBox.Text);
            game = new Game(user);  
            
            ShowNextQuestion();           
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLable.Text = currentQuestion.Text;

            questionNumberLable.Text = game.GetQuestionNumberText();   
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!InputValidator.TryParsToNumber(userAnswerTextBox.Text, out userAnswer, out string errorMasege))
            {
                MessageBox.Show(errorMasege);
            }

            game.AcceptAnswer(userAnswer);

            if(game.End())
            {
                var message = game.DiagnoseCalculate();

                MessageBox.Show(message);
            }
            else
            {
                ShowNextQuestion();
                userAnswerTextBox.Clear();
            }            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();  
        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newQuestionForm = new NewQuestionForm();
            newQuestionForm.ShowDialog();      
          
        }

        private void списокВопросовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questionsListForm = new QuestionsListForm();
            questionsListForm.ShowDialog();
        }
    }
   

}
