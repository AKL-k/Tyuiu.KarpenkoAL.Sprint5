using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarpenkoAL.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty", nameof(path));
            }

            string? directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Это  пример  строки с лишними пробелами.");
            }

            int count = 0;
            using (StreamReader rd = new StreamReader(path)) 
            {
                string? line;
                while ((line = rd.ReadLine()) != null) 
                {
                    MatchCollection matches = Regex.Matches(line, @" {2,}");
                    count += matches.Count;
                }
            }
            return count;
        }
    }
}
