using Tyuiu.KarpenkoAL.Sprint5.Task7.V11.Lib;

namespace Tyuiu.KarpenkoAL.Sprint5.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
