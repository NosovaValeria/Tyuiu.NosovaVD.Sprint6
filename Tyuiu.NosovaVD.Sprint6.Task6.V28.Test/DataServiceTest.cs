using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint6.Task6.V28.Lib;
namespace Tyuiu.NosovaVD.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V28.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "wFrlYaZtHI l eAezSXF eqSGAiC wUdVEuNB";
            Assert.AreEqual(wait, res);
        }
    }
}
