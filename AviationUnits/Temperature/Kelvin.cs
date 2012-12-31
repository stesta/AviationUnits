using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Kelvin : Temperature<Kelvin>
    {
        public Kelvin()
            : this(0.0)
        {

        }

        public Kelvin(ITemperature temperature)
            : this(temperature.To<Kelvin>().Value)
        {

        }

        public Kelvin(double value)
        {
            this.Label = "Degrees Kelvin";
            this.Symbol = "°K";
            this.Value = value;
        }

        public static implicit operator Kelvin(double value)
        {
            return new Kelvin(value);
        }
    }
}
