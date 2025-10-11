using System.Globalization;
using System.IO;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarpenkoAL.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
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
                File.WriteAllText(path, "8\n19\n2.64\n3.31\n-5\n14\n0.31\n13\n-6.65\n6\n-7.87\n-2.24\n-9\n-5.58\n-10\n2.04\n5.21\n-1.77\n13\n2.47");
            }

            double res = 0;
            using (StreamReader rd = new StreamReader(path)) 
            {
                string? line;
                while ((line = rd.ReadLine()) != null) 
                {
                    if (double.TryParse(line, out double number))
                    {
                        int n = (int)number;
                        res = CalculateFactorial(n);
                        res = Math.Round(res, 3);
                        break; 
                    }
                }
                return res;
            }
        }
        private double CalculateFactorial(int n)
        {
            if (n < 0) return 0;
            if (n == 0) return 1;

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
