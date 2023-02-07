using GeniyIdiot.Common;
using System;

namespace GeniyIdiotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            { 
               
                Console.WriteLine("Здравствуйте! Как Вас зовут?");
                var user = new User(Console.ReadLine());              
                var game = new Game(user);

                while (!game.End())
                {
                    var currentQuestion = game.GetNextQuestion();  

                    Console.WriteLine(game.GetQuestionNumberText());
                    Console.WriteLine(currentQuestion.Text);

                    int userAnswer = GetUserAnswer();

                    game.AcceptAnswer(userAnswer);
                }

                var message = game.DiagnoseCalculate();                
                Console.WriteLine(message);

                bool userChoice = GetUserChoice("Хотите посмотреть результаты игры? ");
                if (userChoice)
                {
                    ShowUserResults();
                }
                userChoice = GetUserChoice("Хотите добавить новый вопрос? ");
                if (userChoice)
                {
                    AddNewQuestion();
                }
                userChoice = GetUserChoice("Хотите удалить вопрос? ");
                if (userChoice)
                {
                    RemoveQuestion();
                }
                Console.WriteLine();
                userChoice = GetUserChoice("Хотите повторить тест? ");             
                if (userChoice) continue;
                else
                {
                    break;
                }
            }
        }

        static void RemoveQuestion()
        {
            Console.WriteLine("Введите номер вопроса, который хотите удалить ");
            var questions = QuestionsStorage.Get();
            for(int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + questions[i].Text);
            }
            var removeQuestionNamber = GetUserAnswer();
            while(removeQuestionNamber < 1 || removeQuestionNamber > questions.Count)
            {
                Console.WriteLine("Введите число от 1 до " + questions.Count);
                removeQuestionNamber = GetUserAnswer();
            }
            var removeQuestions = questions[removeQuestionNamber - 1];
            QuestionsStorage.Remove(removeQuestions);
        }

        private static int GetUserAnswer()
        {
            int userAnswer;
            while (!InputValidator.TryParsToNumber(Console.ReadLine(), out userAnswer, out string errorMassege))
                Console.WriteLine(errorMassege);
            return userAnswer;
        }

        static void AddNewQuestion()
        {
            Console.WriteLine("Введите текст вопроса. ");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос. ");
            int answer = GetUserAnswer();
            
            var newQuestion = new Question(text, answer);
            QuestionsStorage.Add(newQuestion);
        }
                
        static bool GetUserChoice(string message)
        {
            while (true)
            {
                Console.WriteLine(message + "Введите Y, для отмены нажмите любую кнопку ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "y")
                {
                    return true;
                }
                else
                {
                    return false;   
                }
            }
        }
        static void ShowUserResults()
        {
            var result = UserResultsStorage.Get();

            Console.WriteLine("{0, -20}{1, 10}{2, 20}", "Имя", "Кол-во правильных ответов", "Диагноз");
            foreach(var user in result) 
            {

                Console.WriteLine("{0, -20}{1, 10}{2, 40}", user.Name, user.CountRightAnswers, user.Diagnose);
            }
        }

    }

}
