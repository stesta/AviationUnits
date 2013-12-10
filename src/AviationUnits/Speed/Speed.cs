using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Speed<T> : Unit<ISpeed>, ISpeed
        where T : ISpeed
    {
        public override Type BaseUnit { get { return typeof(KilometersPerHour); } }
        public override double BaseUnitValue { get { return this.Value * this.Factor; } }

        public static implicit operator double(Speed<T> s)
        {
            return s.Value;
        }

        public static KilometersPerHour operator +(Speed<T> s1, ISpeed s2)
        {
            return new KilometersPerHour((s1.BaseUnitValue + s2.BaseUnitValue));
        }

        public static KilometersPerHour operator -(Speed<T> s1, ISpeed s2)
        {
            return new KilometersPerHour((s1.BaseUnitValue - s2.BaseUnitValue));
        }

        public static KilometersPerHour operator *(Speed<T> s1, ISpeed s2)
        {
            return new KilometersPerHour((s1.BaseUnitValue * s2.BaseUnitValue));
        }

        public static KilometersPerHour operator /(Speed<T> s1, ISpeed s2)
        {
            if (s2.BaseUnitValue == 0)
                throw new DivideByZeroException();

            return new KilometersPerHour((s1.BaseUnitValue / s2.BaseUnitValue));
        }
    }
}
