using GeniyIdiot.Common;
using System;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultsStorage.Get();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.CountRightAnswers, result.Diagnose);
            }

        }
    }
}
