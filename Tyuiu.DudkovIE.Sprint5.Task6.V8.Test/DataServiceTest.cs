using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint5.Task6.V8.Lib;
using System.IO;
namespace Tyuiu.DudkovIE.Sprint5.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.DudkovIE.Sprint5\Tyuiu.DudkovIE.Sprint5.Task6.V8\bin\Debug\InPutDataFileTask6V8.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 19;
            Assert.AreEqual(wait, res);
        }

        public void CheckedExistsFile()
        {

            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.DudkovIE.Sprint5\Tyuiu.DudkovIE.Sprint5.Task6.V8\bin\Debug\InPutDataFileTask6V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
