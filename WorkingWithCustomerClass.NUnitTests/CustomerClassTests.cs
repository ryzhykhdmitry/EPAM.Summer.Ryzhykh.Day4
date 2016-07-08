using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WorkingWithCustomerClass;
using System.Diagnostics;
using System.Globalization;

namespace WorkingWithCustomerClassNUnitTests
{  
    [TestFixture]

    public class NUnitTest
    {
        [Test, TestCaseSource(typeof(CustomerClassTests), "TestMethodCalls")]
        public string ToString_StringOfCertainFormat(string format, IFormatProvider provider)
        {
            Customer current = new Customer("Joseph Albahari", "+1 (111) 111-1111", 123456789);
            return current.ToString(format, provider);
        }
    }

    public class CustomerClassTests
    {        
        CustomerFormatter formatter = new CustomerFormatter();
        public static IEnumerable<TestCaseData> TestMethodCalls
        {
            get
            {
                yield return new TestCaseData(null, null).Returns("Joseph Albahari, 123,456,789.00, +1 (111) 111-1111");
                yield return new TestCaseData("NRP", null).Returns("Joseph Albahari, 123,456,789.00, +1 (111) 111-1111");
                yield return new TestCaseData("NR", null).Returns("Joseph Albahari, 123,456,789.00");
                yield return new TestCaseData("NP", null).Returns("Joseph Albahari, +1 (111) 111-1111");
                yield return new TestCaseData("PR", null).Returns("+1 (111) 111-1111, 123,456,789.00");
                yield return new TestCaseData("N", null).Returns("Joseph Albahari");
                yield return new TestCaseData("P", null).Returns("+1 (111) 111-1111");
                yield return new TestCaseData("R", null).Returns("123,456,789.00");
                yield return new TestCaseData(null, new CustomerFormatter()).Returns("JOSEPH ALBAHARI, 123456789,00, +1 (111) 111 11 11");
                yield return new TestCaseData("NRP", new CustomerFormatter()).Returns("JOSEPH ALBAHARI, 123456789,00, +1 (111) 111 11 11");
                yield return new TestCaseData("NR", new CustomerFormatter()).Returns("JOSEPH ALBAHARI, 123456789,00");
                yield return new TestCaseData("NP", new CustomerFormatter()).Returns("JOSEPH ALBAHARI, +1 (111) 111 11 11");
                yield return new TestCaseData("PR", new CustomerFormatter()).Returns("+1 (111) 111 11 11, 123456789,00");
                yield return new TestCaseData("N", new CustomerFormatter()).Returns("JOSEPH ALBAHARI");
                yield return new TestCaseData("P", new CustomerFormatter()).Returns("+1 (111) 111 11 11");
                yield return new TestCaseData("R", new CustomerFormatter()).Returns("123456789,00");
            }
        }       
    }

}
