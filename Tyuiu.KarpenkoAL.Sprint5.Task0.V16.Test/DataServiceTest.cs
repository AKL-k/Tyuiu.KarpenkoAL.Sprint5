using System.IO;
using Tyuiu.KarpenkoAL.Sprint5.Task0.V16.Lib;

namespace Tyuiu.KarpenkoAL.Sprint5.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            DataService ds = new DataService();
            int testX = 3; 

            string actualPath = ds.SaveToFileTextData(testX);

            FileInfo fileInfo = new FileInfo(actualPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists, $"Файл не найден по пути: {actualPath}");
        }
    }
}
