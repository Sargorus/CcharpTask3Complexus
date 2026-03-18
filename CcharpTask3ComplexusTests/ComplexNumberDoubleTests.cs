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
    }
}