using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AviationUnits.Tests
{
    [TestClass]
    public class Pressure_Units_Should
    {
        [TestMethod]
        public void Convert_InchesOfMercury_and_Millibars()
        {
            double inchesofmercury_millibars = new InchesOfMercury(1).To<Millibars>();  // 33.86
            double millibars_inchesofmercury = new Millibars(1).To<InchesOfMercury>();  // 0.0295

            Assert.AreEqual(33.86, Math.Round(inchesofmercury_millibars, 2));
            Assert.AreEqual(0.0295, Math.Round(millibars_inchesofmercury, 4));
        }
    }
}
