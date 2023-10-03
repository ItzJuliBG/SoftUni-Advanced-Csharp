namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using StreamReader sr = new StreamReader(inputFilePath);

            StringBuilder text = new StringBuilder();
            text.Append(sr.ReadToEnd());
            string t = "--,.!?";
            char[] c =t.ToCharArray();
            foreach (char ch in c)
            {
                text = text.Replace(ch, '@') ;
            }


            return text.Reverse().ToString();
        }
    }
}
