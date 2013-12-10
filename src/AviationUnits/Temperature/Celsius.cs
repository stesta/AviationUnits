using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class Celsius : Temperature<Celsius>
    {
        public Celsius()
            : this(0.0)
        {

        }

        public Celsius(ITemperature temperature)
            : this(temperature.To<Celsius>().Value)
        {

        }

        public Celsius(double value)
        {
            this.Label = "Degrees Celcius";
            this.Symbol = "°C";
            this.Value = value;
        }

        public static implicit operator Celsius(double value)
        {
            return new Celsius(value);
        }
    }
}
