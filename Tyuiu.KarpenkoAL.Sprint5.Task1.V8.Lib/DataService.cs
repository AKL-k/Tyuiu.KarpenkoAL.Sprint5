using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarpenkoAL.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask1.txt");

            File.WriteAllText(path, string.Empty);

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                double b = 2 * x - 2;

                if (Math.Abs(b) < 1e-10)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2)), 2);
                }

                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
