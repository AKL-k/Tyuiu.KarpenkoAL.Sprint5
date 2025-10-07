using Tyuiu.KarpenkoAL.Sprint5.Task1.V8.Lib;

namespace Tyuiu.KarpenkoAL.Sprint5.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string actualPath = ds.SaveToFileTextData(startValue, stopValue);

            FileInfo fileInfo = new FileInfo(actualPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists, $"Файл не найден по пути: {actualPath}");
        }
    }
}
