using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private static string fileName = "questions.json";
        public static List<Question> Get()           
        {
            var questions = new List<Question>();
            if (FileProvider.Exists(fileName))
            {
                var value = FileProvider.GetValue(fileName);
                questions = JsonConvert.DeserializeObject<List<Question>>(value);
                
            }
            else
            {

                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно разделить на 10 частей, сколько надо сделать распилов?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                SaveQuestions(questions);
            }
            return questions;
        }

        public static void SaveQuestions(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions);  
            FileProvider.Replace(fileName, jsonData);
        }

        public static void Add(Question newQuestion)
        {
            var questions = Get();
            questions.Add(newQuestion);
            SaveQuestions(questions);
            
        }

        public static void Remove(Question removeQuestions)
        {
            var questions = Get();
            for(int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == removeQuestions.Text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            SaveQuestions(questions);
        }
        public static void Remove(string text)
        {
            var questions = Get();
            for (int i = 0; i < questions.Count; i++)
            {
                if (questions[i].Text == text)
                {
                    questions.RemoveAt(i);
                    break;
                }
            }
            SaveQuestions(questions);
        }
    }

}
