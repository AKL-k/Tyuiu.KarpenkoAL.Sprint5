using System.IO;
using Tyuiu.KarpenkoAL.Sprint5.Task4.V6.Lib;

namespace Tyuiu.KarpenkoAL.Sprint5.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
