namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;

        public User(string name)
        {
            Name = name;
            Diagnose = "";
        }
        public void AsseptRightAnswer()
        {
            CountRightAnswers++;  
        }

    }

}
