using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AviationUnits.Tests
{
    [TestClass]
    public class Temperature_Units_Should
    {
        [TestMethod]
        public void Convert_Kelvin_and_Celcius()
        {
            Kelvin kelvin = 273.15;
            Celsius celcius = 0.0;

            var conversion1 = kelvin.To<Celsius>();
            var conversion2 = celcius.To<Kelvin>();

            Assert.AreEqual(celcius.Value, conversion1.Value);
            Assert.AreEqual(kelvin.Value, conversion2.Value);
        }

        [TestMethod]
        public void Convert_Kelvin_and_Fahrenheit()
        {
            Kelvin kelvin = 273.15;
            Fahrenheit fahrenheit = 32;

            var conversion1 = kelvin.To<Fahrenheit>();
            var conversion2 = fahrenheit.To<Kelvin>();

            Assert.AreEqual(fahrenheit.Value, conversion1.Value);
            Assert.AreEqual(kelvin.Value, conversion2.Value);
        }

        [TestMethod]
        public void Convert_Celcius_and_Fahrenheit()
        {
            Celsius celcius = 6;
            Fahrenheit fahrenheit = 42.8;

            var conversion1 = celcius.To<Fahrenheit>();
            var conversion2 = fahrenheit.To<Celsius>();

            Assert.AreEqual(fahrenheit.Value, conversion1.Value);
            Assert.AreEqual(celcius.Value, conversion2.Value);
        }
    }
}
