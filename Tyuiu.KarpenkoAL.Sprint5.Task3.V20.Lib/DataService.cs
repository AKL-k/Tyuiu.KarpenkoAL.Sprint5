using System.IO;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KarpenkoAL.Sprint5.Task3.V20.Lib
{
    public class DataService : ISprint5Task3V20
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask3.bin");

            File.WriteAllText(path, string.Empty);

            double denominator = Math.Sqrt(Math.Pow(x, 2) + x);

            double y = Math.Round(x / denominator, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8)) 
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}
