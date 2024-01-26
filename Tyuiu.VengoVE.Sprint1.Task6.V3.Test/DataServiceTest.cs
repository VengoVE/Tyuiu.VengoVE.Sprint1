using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint1.Task6.V3.Lib;

namespace Tyuiu.VengoVE.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "Hello World";
            string res = ds.LastLetterWord(strTest);
            string wait = "";
            Assert.AreEqual(wait, res);
        }
    }
}
