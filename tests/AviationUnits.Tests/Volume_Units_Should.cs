using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AviationUnits.Tests
{
    [TestClass]
    public class Volume_Units_Should
    {
        [TestMethod]
        public void Convert_Liters_and_USGallons()
        {
            double liters_gal = new Liters(10).To<USGallons>();     // 2.64172
            double gal_liters = new USGallons(1).To<Liters>();      // 3.78541

            Assert.AreEqual(2.64172, Math.Round(liters_gal, 5));
            Assert.AreEqual(3.78541, Math.Round(gal_liters, 5));
        }
    }
}
