using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint6.Task7.V29.Lib;
using System.IO;
namespace Tyuiu.NosovaVD.Sprint6.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            string path = @"C:\Users\Валерия\source\repos\Tyuiu.NosovaVD.Sprint6\Tyuiu.NosovaVD.Sprint6.Task7.V29\bin\Debug\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
