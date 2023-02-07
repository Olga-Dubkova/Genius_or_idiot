using System;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuestionsListForm : Form
    {
        public QuestionsListForm()
        {
            InitializeComponent();
        }

        private void QuestionsList_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.Get();
            foreach (var question in questions)
            {
                questionsdataGridView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rows = questionsdataGridView.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали строку!");
                return;
            }
            var questionText = rows[0].Cells[0].Value.ToString();
            if (questionText != null)
            {
                QuestionsStorage.Remove(questionText);
                Close();
            }
        }
    }
}
