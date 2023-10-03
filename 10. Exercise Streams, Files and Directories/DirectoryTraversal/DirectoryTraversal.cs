namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Channels;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
           
            string[] fileNames= Directory.GetFiles(inputFolderPath);

           foreach (var fileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fileName);
                if (!dict.ContainsKey(fileInfo.Extension))
                {
                    dict.Add(fileInfo.Extension, new List<string>());
                }
                dict[fileInfo.Extension].Add(fileName);
            }
           StringBuilder sb = new StringBuilder();

            foreach (var fileExt in dict)
            {
                sb.AppendLine($".{fileExt.Key}");
                fileExt.Value.Join(sb.AppendLine("fw"));
            }
           

            return null;
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            throw new NotImplementedException();
        }
    }
}
