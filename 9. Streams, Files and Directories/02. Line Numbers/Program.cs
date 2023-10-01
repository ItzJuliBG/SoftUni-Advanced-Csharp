namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            RewriteFileWithLineNumbers(inputPath, outputPath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string
       outputFilePath)
        {
            StreamReader sr = new StreamReader(inputFilePath);
            int count =0;
            while(!sr.EndOfStream)
            {
                count++;
                Console.WriteLine($"{count}. {sr.ReadLine()}");
            }
        }
    }
}