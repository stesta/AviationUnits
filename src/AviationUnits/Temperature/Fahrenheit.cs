using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Fahrenheit : Temperature<Fahrenheit>
    {
        public Fahrenheit()
            : this(0.0)
        {

        }

        public Fahrenheit(ITemperature temperature)
            : this(temperature.To<Fahrenheit>().Value)
        {

        }

        public Fahrenheit(double value)
        {
            this.Label = "Degrees Fahrenheit";
            this.Symbol = "°F";
            this.Value = value;
        }

        public static implicit operator Fahrenheit(double value)
        {
            return new Fahrenheit(value);
        }
    }
}
