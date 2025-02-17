using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nikitalab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nikitalab1.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        [TestMethod()]
        [DataRow(121, "1 рубль 21 копейка")]
        [DataRow(5, "5 копеек")]
        [DataRow(150, "1 рубль 50 копеек")]
        [DataRow(100, "1 рубль")]
        [DataRow(0, "0 рублей")]
        [DataRow(9999, "99 рублей 99 копеек")]
        public void ConvertCost_ShouldReturnCorrectResult(int n, string expected)
        {
            // Act
            string result = Converter.ConvertCost(n);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
