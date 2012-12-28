using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Temperature<T> : Unit<ITemperature>, ITemperature
        where T : ITemperature
    {
        public override Type BaseUnit { get { return typeof(Kelvin); } }
        public override double BaseUnitValue { get { return this.To<Kelvin>().Value; } }

        //
        // Operators

        public static implicit operator double(Temperature<T> t)
        {
            return t.Value;
        }

        public static Kelvin operator +(Temperature<T> t1, ITemperature t2)
        {
            return new Kelvin((t1.BaseUnitValue + t2.BaseUnitValue));
        }

        public static Kelvin operator -(Temperature<T> t1, ITemperature t2)
        {
            return new Kelvin((t1.BaseUnitValue - t2.BaseUnitValue));
        }
    }
}
