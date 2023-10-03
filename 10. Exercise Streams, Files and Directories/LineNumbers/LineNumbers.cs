namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using StreamReader sr = new StreamReader(inputFilePath);
            while(!sr.EndOfStream)
            {
                int line = 1;
                int letterCount = 0;
                int symbolsCount = 0;

            string text = sr.ReadLine();
                foreach (char c in text)
                {
                    if (Char.IsLetter(c))
                    {
                        letterCount++;
                    }
                    else if (Char.IsPunctuation(c))
                    {
                        symbolsCount++;
                        
                    }
                }
                Console.WriteLine($"Line {line}: {text} ({letterCount}) ({symbolsCount})");
                line++;
            }
        }
    }
}
