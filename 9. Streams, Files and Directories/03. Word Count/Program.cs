using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
using System.Xml;

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
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string text = string.Empty;
            string pattern = @"[A-Za-z]+";

            using (StreamReader sr1 =  new StreamReader(textFilePath)) 
            {
                text = sr1.ReadToEnd();
                text = text.ToLower();
                
                using(StreamReader sr2 =  new StreamReader(wordsFilePath))
                {
                    string[] filter = sr2.ReadToEnd().Split().ToArray();
                    
                    foreach(Match word in Regex.Matches(text, pattern)) 
                    {
                        foreach (string element in filter)
                        {
                            if (element == word.Value)
                            {
                                if (!dict.ContainsKey(word.Value))
                                {
                                    dict.Add(word.Value, 0);
                                }
                                dict[word.Value]++;
                            }
                        }
                    }
                }
                var sortedDict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (var t in sortedDict)
                {
                    Console.WriteLine($"{t.Key} - {t.Value}");
                }
            }
        }
    }
}
