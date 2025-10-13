using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarpenkoAL.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
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
                File.WriteAllText(path, "Привет, как дела? Он написал письмо. Он ссорился с другом вчера.");
            }

            string tempPath = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPath, "OutPutDataFileTask7V11.txt");

            File.WriteAllText(pathSaveFile, string.Empty);

            using (StreamReader rd = new StreamReader(path)) 
            {
                string strLine = "";
                string? line;
                while ((line = rd.ReadLine()) != null) 
                { 
                        foreach (char c in line) 
                        {
                            if (!IsRussianLower(c)) 
                            {
                                strLine += c;
                            }
                        }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }

            return pathSaveFile;
        }

        private bool IsRussianLower(char c)
        {
            return (c >= 'а' && c <= 'я') || c == 'ё';
        }
    }
}
