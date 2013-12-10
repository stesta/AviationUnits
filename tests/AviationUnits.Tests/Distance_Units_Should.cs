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
            double m_ft = new Meters(100).To<Feet>();    // 328.083
            double ft_m = new Feet(30).To<Meters>();     // 9.144

            Assert.AreEqual(328.084, Math.Round(m_ft, 3));
            Assert.AreEqual(9.144, Math.Round(ft_m, 3));
        }

        [TestMethod]
        public void Convert_Kilometers_and_NauticalMiles()
        {
            double M_km = new NauticalMiles(100).To<Kilometers>();  // 185.2
            double km_M = new Kilometers(50).To<NauticalMiles>();   // 26.9978

            Assert.AreEqual(185.2, Math.Round(M_km, 4));
            Assert.AreEqual(26.9978, Math.Round(km_M, 4));
        }

        [TestMethod]
        public void Convert_NauticalMiles_and_StatuteMiles()
        {
            double M_mi = new NauticalMiles(87).To<StatuteMiles>();     // 100.118
            double mi_M = new StatuteMiles(115).To<NauticalMiles>();    // 99.9324

            Assert.AreEqual(100.118, Math.Round(M_mi, 3));
            Assert.AreEqual(99.9323, Math.Round(mi_M, 4));
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
