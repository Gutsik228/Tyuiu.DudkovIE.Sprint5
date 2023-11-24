using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint5.Task7.V20.Lib;
using System.IO;
namespace Tyuiu.DudkovIE.Sprint5.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.DudkovIE.Sprint5\Tyuiu.DudkovIE.Sprint5.Task7.V20\bin\Debug\";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, true);
        }
    }
}
