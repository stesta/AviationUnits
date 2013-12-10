using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Angle<T> : Unit<IAngle>, IAngle
        where T : IAngle
    {
        public override Type BaseUnit { get { return typeof(Radians); } }
        public override double BaseUnitValue { get { return this.Value * this.Factor; } }

        public static implicit operator double(Angle<T> a)
        {
            return a.Value;
        }

        public static Radians operator +(Angle<T> a1, IAngle a2)
        {
            return new Radians((a1.BaseUnitValue + a2.BaseUnitValue));
        }

        public static Radians operator -(Angle<T> a1, IDistance a2)
        {
            return new Radians((a1.BaseUnitValue - a2.BaseUnitValue));
        }

        public static Radians operator *(Angle<T> a1, IDistance a2)
        {
            return new Radians((a1.BaseUnitValue * a2.BaseUnitValue));
        }
        public static Radians operator /(Angle<T> a1, IDistance a2)
        {
            if (a2.BaseUnitValue == 0)
                throw new DivideByZeroException();

            return new Radians((a1.BaseUnitValue / a2.BaseUnitValue));
        }
    }
}
