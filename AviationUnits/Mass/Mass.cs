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
        public override Type BaseUnit { get { return typeof(Kilograms); } }
        public override double BaseUnitValue { get { return this.Value * this.Factor; } }

        public static implicit operator double(Mass<T> d)
        {
            return d.Value;
        }

        public static Kilograms operator +(Mass<T> m1, IMass m2)
        {
            return new Kilograms((m1.BaseUnitValue + m2.BaseUnitValue));
        }

        public static Kilograms operator -(Mass<T> m1, IMass m2)
        {
            return new Kilograms((m1.BaseUnitValue - m2.BaseUnitValue));
        }

        public static Kilograms operator *(Mass<T> m1, IMass m2)
        {
            return new Kilograms((m1.BaseUnitValue * m2.BaseUnitValue));
        }

        public static Kilograms operator /(Mass<T> m1, IMass m2)
        {
            if (m2.BaseUnitValue == 0)
                throw new DivideByZeroException();

            return new Kilograms((m1.BaseUnitValue * m2.BaseUnitValue));
        }
    }
}
