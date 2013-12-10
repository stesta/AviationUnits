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
            double kgs_lbs = new Kilograms(12).To<Pounds>();   // 26.4555
            double lbs_kgs = new Pounds(25).To<Kilograms>();   // 11.3398

            Assert.AreEqual(26.4555, Math.Round(kgs_lbs, 4));
            Assert.AreEqual(11.3398, Math.Round(lbs_kgs, 4));
        }
    }
}
