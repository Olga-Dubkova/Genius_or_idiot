using System;

namespace GeniyIdiot.Common
{
    public class InputValidator
    {
        public static bool TryParsToNumber(string input, out int number, out string errorMassege)
        {
            try
            {
                number = Convert.ToInt32(input);
                errorMassege = "";
                return true;
            }
            catch (FormatException)
            {
                errorMassege = "Введите число";
                number = 0;
                return false;
            }
            catch (OverflowException)
            {
                errorMassege = "Введите число от -2*10^9 до 2*10^9";
                number = 0;
                return false;
            }
        }
    }
}
