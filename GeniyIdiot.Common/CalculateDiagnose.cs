using System;


namespace GeniyIdiot.Common
{
    public class CalculateDiagnose
    {
  
        public static string Get(int countQuestions, int countRightAnswers)
        {
            string[] diagnoses = GetDiagnoses();
            double persentAnswers = Convert.ToDouble(countRightAnswers) / countQuestions * 100;

            string userDiagnoses = "";
            if (persentAnswers == 100)
                userDiagnoses = diagnoses[5];
            if (persentAnswers >= 80 && persentAnswers < 100)
                userDiagnoses = diagnoses[4];
            if (persentAnswers >= 60 && persentAnswers < 80)
                userDiagnoses = diagnoses[3];
            if (persentAnswers >= 40 && persentAnswers < 60)
                userDiagnoses = diagnoses[2];
            if (persentAnswers >= 20 && persentAnswers < 40)
                userDiagnoses = diagnoses[1];
            if (persentAnswers < 20)
                userDiagnoses = diagnoses[0];
            return userDiagnoses;
        }
        public static string[] GetDiagnoses()
        {
            string[] diagnoses = new string[] { "Идиот", "Кретин", "Дурак", "Нормальный", "Талант", "Гений" };

            return diagnoses;
        }
    }
}
