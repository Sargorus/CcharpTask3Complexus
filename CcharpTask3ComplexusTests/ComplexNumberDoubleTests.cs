using Microsoft.VisualStudio.TestTools.UnitTesting;
using CcharpTask3Complexus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcharpTask3Complexus.Tests
{
    [TestClass()]
    public class ComplexNumberDoubleTests
    {

        [TestMethod()]
        public void ComplexNumberDoubleToStringTest()
        {
            var testComplexNumber = new ComplexNumberDouble(12, 122);
            Assert.AreEqual("Вещественная часть 12, Мнимая 122", testComplexNumber.ToString());
        }

        [TestMethod()]
        public void ComplexNumberDoubleAddingComplex()
        {
            var testComplexNumberA = new ComplexNumberDouble(12, 122);
            var testComplexNumberB = new ComplexNumberDouble(12, 3);
            var testComplexNumberSum = testComplexNumberA + testComplexNumberB;
            var testComplexNumberSumEtalon = new ComplexNumberDouble(24, 125);
            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));
        }

        [TestMethod()]
        public void ComplexNumberDoubleAddingInt()
        {
            var testComplexNumberA = new ComplexNumberDouble(12, 122);
            var testNumberB = 100;
            var testComplexNumberSum = testComplexNumberA + testNumberB;

            var testComplexNumberSumEtalon = new ComplexNumberDouble(112, 122);

            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));
        }

        [TestMethod()]
        public void IntAddingComplexNumberDouble()
        {
            double testNumberA = 304.30;
            var testComplexNumberB = new ComplexNumberDouble(12, 122);
            var testComplexNumberSum = testNumberA + testComplexNumberB;

            var testComplexNumberSumEtalon = new ComplexNumberDouble(316.30, 122);
            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));
        }

        [TestMethod()]
        public void IntAddingComplexNumberFloat()
        {
            float testNumberA = 3.1415f;
            var testComplexNumberB = new ComplexNumberDouble(12, 122);
            var testComplexNumberSum = testNumberA + testComplexNumberB;

            var testComplexNumberSumEtalon = new ComplexNumberDouble(15.1415, 122);
            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));
        }

        [TestMethod()]
        public void ComplexNumberDoubleSubtractingComplex()
        {
            var testComplexNumberA = new ComplexNumberDouble(12, 122);
            var testComplexNumberB = new ComplexNumberDouble(12, 3);
            var testComplexNumberSum = testComplexNumberA - testComplexNumberB;

            var testComplexNumberSumEtalon = new ComplexNumberDouble(0, 119);
            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));
        }

        [TestMethod()]
        public void ComplexNumberDoubleDivisionComplex()
        {
            var testComplexNumberA = new ComplexNumberDouble(10, 12);
            var testComplexNumberB = new ComplexNumberDouble(5, 3);
            var testComplexNumberSum = testComplexNumberA / testComplexNumberB;

            var testComplexNumberSumEtalon = new ComplexNumberDouble(2.5294117647058822, 0.8823529411764706);
            //Assert.AreEqual("Вещественная часть 12, Мнимая 122", testComplexNumberSum.ToString());
            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));
        }

        [TestMethod()]
        public void ComplexNumberDoubleDivisionComplexZero()
        {
            var testComplexNumberA = new ComplexNumberDouble(10, 12);
            var testComplexNumberB = new ComplexNumberDouble(0, 0);
            var testComplexNumberSum = testComplexNumberA / testComplexNumberB;

            var testComplexNumberSumEtalon = new ComplexNumberDouble(0, 0);
            // Assert.AreEqual("Вещественная часть 12, Мнимая 122", testComplexNumberSum.ToString());
            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));

            // Тут деление на 0, и должно быть исключение. Как проверить я чет не знаю как
        }


        [TestMethod()]
        public void ComplexNumberDoubleAddingInt()
        {
            var testComplexNumberA = new ComplexNumberDouble(10, 12);
            var testNumberB = 4;
            var testComplexNumberSum = testComplexNumberA + testNumberB;

            var testComplexNumberSumEtalon = new ComplexNumberDouble(14, 12);
            // Assert.AreEqual("Вещественная часть 12, Мнимая 122", testComplexNumberSum.ToString());
            Assert.AreEqual(true, testComplexNumberSum.ComplexСomparisonEquality(testComplexNumberSumEtalon));

        }

    }
}