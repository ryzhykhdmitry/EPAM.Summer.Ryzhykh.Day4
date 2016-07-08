using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoubleExtension.NUnitTests
{
    [TestFixture]
    public class DoubleExtencionTests
    {
        [Test, TestCaseSource(typeof(MyDataClass), "TestCases")]
        public void ConvertDouble_Minus100toBits_Bits(double number, string result)
        {
            string tempString;
            tempString = number.ToBit();
            Assert.AreEqual(result, tempString);
        }
    }

    public class MyDataClass
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(-7111991, "1100000101011011001000010100110111000000000000000000000000000000");
                yield return new TestCaseData(75842310111, "0100001000110001101010001000110111001111110111110000000000000000");
                yield return new TestCaseData(double.MaxValue, "0111111111101111111111111111111111111111111111111111111111111111");
                yield return new TestCaseData(double.NaN, "1111111111111000000000000000000000000000000000000000000000000000");                
            }
        }
    }
}
