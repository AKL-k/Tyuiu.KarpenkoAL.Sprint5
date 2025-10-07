using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarpenkoAL.Sprint5.Task0.V16.Lib
{
    public class DataService : ISprint5Task0V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask0.txt");

            double z = (2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2));

            z = Math.Round(z, 3);
            File.WriteAllText(path, z.ToString());
            return path;
        }
    }
}
