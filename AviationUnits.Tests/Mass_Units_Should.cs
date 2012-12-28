using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AviationUnits.Tests
{
    [TestClass]
    public class Mass_Units_Should
    {
        [TestMethod]
        public void Convert_Kilograms_and_Pounds()
        {
            Kilogram kilograms = 1;
            Pound pounds = 2.20462;

            var conversion1 = Math.Round(kilograms.To<Pound>(), 5);
            var conversion2 = Math.Round(pounds.To<Kilogram>(), 5);

            Assert.AreEqual(pounds.Value, conversion1);
            Assert.AreEqual(kilograms.Value, conversion2);
        }
    }
}
