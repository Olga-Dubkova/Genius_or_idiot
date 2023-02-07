using System.IO;
using System.Text;

namespace GeniyIdiot.Common

{
    public class FileProvider
    {
        public static void Append(string fileName, string value)
        {
            StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }
        public static void Replace(string fileName, string value)
        {
            StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static bool Exists(string fileName)
        {
           return File.Exists(fileName);
        }

        public static string GetValue(string fileName)
        {
            StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
            var value = reader.ReadToEnd(); 
            reader.Close();
            return value;   
        }

        internal static void Clear(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
        }
    }

}
