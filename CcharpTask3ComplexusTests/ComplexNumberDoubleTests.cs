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
            Assert.AreEqual("Вещественная часть 12, Мнимая 122", testComplexNumber.ComplexNumberDoubleToString());
        }

        [TestMethod()]
        public void ComplexNumberDoubleAddingComplex()
        {
            var testComplexNumberA = new ComplexNumberDouble(12, 122);
            var testComplexNumberB = new ComplexNumberDouble(12, 3);
            var testComplexNumberSum = testComplexNumberA + testComplexNumberB;
            Assert.AreEqual("Вещественная часть 24, Мнимая 125", testComplexNumberSum.ComplexNumberDoubleToString());
        }

        [TestMethod()]
        public void ComplexNumberDoubleAddingInt()
        {
            var testComplexNumberA = new ComplexNumberDouble(12, 122);
            var testComplexNumberB = 100;
            var testComplexNumberSum = testComplexNumberA + testComplexNumberB;
            Assert.AreEqual("Вещественная часть 112, Мнимая 122", testComplexNumberSum.ComplexNumberDoubleToString());
        }

        [TestMethod()]
        public void IntAddingComplexNumberDouble()
        {
            var testComplexNumberA = 304;
            var testComplexNumberB = new ComplexNumberDouble(12, 122);
            var testComplexNumberSum = testComplexNumberA + testComplexNumberB;
            Assert.AreEqual("Вещественная часть 316, Мнимая 122", testComplexNumberSum.ComplexNumberDoubleToString());
        }

        [TestMethod()]
        public void ComplexNumberDoubleSubtractingComplex()
        {
            var testComplexNumberA = new ComplexNumberDouble(12, 122);
            var testComplexNumberB = new ComplexNumberDouble(12, 3);
            var testComplexNumberSum = testComplexNumberA - testComplexNumberB;
            Assert.AreEqual("Вещественная часть 0, Мнимая 119", testComplexNumberSum.ComplexNumberDoubleToString());
        }

    }
}