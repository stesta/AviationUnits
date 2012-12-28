using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AviationUnits.Tests
{
    [TestClass]
    public class Distance_Units_Should
    {
        [TestMethod]
        public void Convert_Meters_and_Feet()
        {
            // These two values are equivalent
            Meters meters = 5;
            Feet feet = 16.4041995;
            
            double conversion1 = Math.Round(meters.To<Feet>(), 7);   // meters to feet
            double conversion2 = Math.Round(feet.To<Meters>(), 7);    // feet to meters

            Assert.IsTrue(conversion1 == feet);
            Assert.IsTrue(conversion2 == meters);
        }

        [TestMethod]
        public void Convert_Feet_and_StatuteMiles()
        {
            StatuteMiles miles = 1;
            Feet feet = 5280;

            var conversion1 = miles.To<Feet>().Value;
            var conversion2 = feet.To<StatuteMiles>().Value;

            Assert.IsTrue(conversion1 == feet);
            Assert.IsTrue(conversion2 == miles);
        }

        [TestMethod]
        public void Correctly_Add_Distances_of_Different_Types()
        {
            // These two values are equivalent, 
            // Therefore the result should be double the meters
            Meters meters = 5.1954;
            Feet feet = 17.0452756;
            
            var expected = 10.3908;
            var result = meters + feet;

            Assert.IsTrue(expected == Math.Round(result, 4));
            Assert.IsTrue(result.GetType() == typeof(Meters)); // check that type returned is Meters (base unit)
        }
    }
}
