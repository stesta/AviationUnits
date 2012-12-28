using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AviationUnits.Tests
{
    [TestClass]
    public class Angle_Units_Should
    {
        [TestMethod]
        public void Convert_Radians_to_Degrees()
        {
            Radian radians = 1;
            Degree degrees = 57.2957795;

            var conversion1 = Math.Round(radians.To<Degree>(), 7);
            var conversion2 = Math.Round(degrees.To<Radian>(), 7);

            Assert.IsTrue(conversion1 == degrees);
            Assert.IsTrue(conversion2 == radians);
        }

        [TestMethod]
        public void Correctly_Add_Angles_of_Different_Types()
        {
            Radian radians = 1;
            Degree degrees = 57.2957795;

            var expected = 2;
            var result = radians + degrees;

            Assert.IsTrue(expected == Math.Round(result, 7));
        }
    }
}
