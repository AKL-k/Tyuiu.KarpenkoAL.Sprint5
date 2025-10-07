using Microsoft.ApplicationInsights;
using Tyuiu.KarpenkoAL.Sprint5.Task2.V5.Lib;

namespace Tyuiu.KarpenkoAL.Sprint5.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[3, 3] { { 9, 6, 6 },
                                          { 8, 7, 2 },
                                          { 1, 7, 8 }, };

            string actualPath = ds.SaveToFileTextData(mas2);

            FileInfo fileInfo = new FileInfo(actualPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists, $"Файл не найден по пути: {actualPath}");
        }
    }
}
