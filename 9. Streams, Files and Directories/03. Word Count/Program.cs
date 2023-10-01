namespace WordCount
{
    public class WordCount
    {
        static void Main()
         {
            string wordPath = @"..\..\..\words.txt";
            string textPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string
       textFilePath, string outputFilePath)
        {
            StreamReader words = new StreamReader(wordsFilePath);
            StreamReader inputText = new StreamReader(textFilePath);

            

            Dictionary<string, int> dict = new();
            string t = words.ReadToEnd().ToLower();
            string[] wordFilter = t.Split().ToArray();
            string temp = inputText.ReadToEnd().ToLower();
           
            List<string> text = temp.Split().ToList();
            int count = 0;



            foreach (var currentFilter in wordFilter)
            {

                foreach (var currentWord in text)
                {
                   foreach(var word in currentWord)
                    {
                        if (currentWord == '.' || currentWord == ',' || currentWord == '!' || currentWord == '@' || currentWord == ' & ' || currentWord == _')
                        {
                        }

                        text.Remove(currentWord);
                    }
                    if (currentFilter==currentWord)
                    {
                    count++;

                    }
                }
                    //Console.WriteLine($"{currentFilter} - {count}");
                    count = 0;
            }
        }
    }
}
