using System;
using GeniyIdiot.Common;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class NewQuestionForm : Form
    {
        
        public NewQuestionForm()
        {
            InitializeComponent();
        }
      
        public void AddQuestionButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParsToNumber(addAnswerTextBox.Text, out int answer, out string errorMasege);
            if (!parsed)
            {
                MessageBox.Show(errorMasege);
            }
            else
            {
                var newQuestion = new Question(addQuestionTextBox.Text, answer);
                QuestionsStorage.Add(newQuestion);
            }
            Close();
      
        }

        
    }

        
}

