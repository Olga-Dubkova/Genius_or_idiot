using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiot.Common
{
    public class Game
    {
        User user;
        List<Question> questions;
        Question currentQuestion;
        int countQuestions;
        int questionNumber = 0;
        int answer;
        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.Get();
            countQuestions = questions.Count;
        }
        public Question GetNextQuestion()
        {
            Random random = new Random();
            var randomQuestionsIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionsIndex];

            questionNumber++;

            return currentQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AsseptRightAnswer();
            }
            questions.Remove(currentQuestion);

        }
        public string GetQuestionNumberText()
        {
            return "Вопрос №" + questionNumber;
        }
        public bool End()
        {
            return questions.Count == 0;
        }
        public string DiagnoseCalculate()
        {
            string userDiagnoses = CalculateDiagnose.Get(countQuestions, user.CountRightAnswers);
            user.Diagnose = userDiagnoses;

            UserResultsStorage.Save(user);
            return "Ваш диагноз: " + userDiagnoses;
        }
    }
   
}
