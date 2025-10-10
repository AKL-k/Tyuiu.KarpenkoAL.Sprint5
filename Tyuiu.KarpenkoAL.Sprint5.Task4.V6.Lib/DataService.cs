using System.Globalization;
using System.IO;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.KarpenkoAL.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double result = (1 / Math.Cos(x)) + 2.2 * Math.Pow(x, 2);

            return Math.Round(result, 3);

        }
    }
}
