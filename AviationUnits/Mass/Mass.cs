using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Mass<T> : Unit<IMass>, IMass
        where T : IMass
    {
        public override Type BaseUnit { get { return typeof(Kilogram); } }

        public static implicit operator double(Mass<T> d)
        {
            return d.Value;
        }

        public static Kilogram operator +(Mass<T> m1, IMass m2)
        {
            return new Kilogram((m1.BaseUnitValue + m2.BaseUnitValue));
        }

        public static Kilogram operator -(Mass<T> m1, IMass m2)
        {
            return new Kilogram((m1.BaseUnitValue - m2.Value));
        }
    }
}
