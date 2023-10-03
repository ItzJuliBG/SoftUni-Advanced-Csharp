namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\example.png";
            string bytesFilePath = @"..\..\..\bytes.txt";
            string outputPath = @"..\..\..\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string
       bytesFilePath, string outputPath)
        {
            using (StreamReader bytes = new StreamReader(bytesFilePath))
            {
                string[] filter = bytes.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (var filterIndex in filter) {
                    Console.WriteLine(filterIndex);
                }
                using (StreamReader pngBinary = new StreamReader(binaryFilePath))
                {
                    byte[] t = ;
                    Console.WriteLine();
                }
                // not ready yet
            }
        }
    }
}