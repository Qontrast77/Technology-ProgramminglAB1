using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nikitalab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikitalab1.Tests
{
    public class ConverterTests
    {
        [Theory]
        [InlineData(121, "1 рубль 21 копейка")]
        [InlineData(5, "5 копеек")]
        [InlineData(150, "1 рубль 50 копеек")]
        [InlineData(100, "1 рубль")]
        [InlineData(0, "0 рублей")]
        [InlineData(9999, "99 рублей 99 копеек")]
        public void ConvertCost_ShouldReturnCorrectResult(int n, string expected)
        {
            // Act
            string result = Converter.ConvertCost(n);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}