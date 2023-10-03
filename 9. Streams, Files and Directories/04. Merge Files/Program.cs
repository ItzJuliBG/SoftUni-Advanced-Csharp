namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath,
           outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using(StreamReader sr = new StreamReader(firstInputFilePath)) 
            { 
                using (StreamReader sr2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(outputFilePath))
                    {
                        while (!sr.EndOfStream || !sr.EndOfStream)
                        {
                            string firstLine = sr.ReadLine();
                            string secondLine = sr2.ReadLine();
                            sw.WriteLine(firstLine);
                            sw.WriteLine(secondLine);
                        }
                    }
                }

            }
        }
    }
}