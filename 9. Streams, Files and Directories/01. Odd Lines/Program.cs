namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string
       outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);

            while (!reader.EndOfStream)
            {
                var disposableLine = reader.ReadLine();
                var t =reader.ReadLine();
                Console.WriteLine(t);

            }
        }
    }
}