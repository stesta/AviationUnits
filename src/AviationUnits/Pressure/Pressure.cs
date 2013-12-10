using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public class Pressure<T> : Unit<IPressure>, IPressure
        where T : IPressure
    {
        public override Type BaseUnit { get { return typeof(InchesOfMercury); } }
        public override double BaseUnitValue { get { return this.Value * this.Factor; } }

        //
        // Operators

        public static implicit operator double(Pressure<T> p)
        {
            return p.Value;
        }

        public static InchesOfMercury operator +(Pressure<T> p1, IPressure p2)
        {
            return new InchesOfMercury((p1.BaseUnitValue + p2.BaseUnitValue));
        }

        public static InchesOfMercury operator -(Pressure<T> p1, IPressure p2)
        {
            return new InchesOfMercury((p1.BaseUnitValue - p2.BaseUnitValue));
        }

        public static InchesOfMercury operator *(Pressure<T> p1, IPressure p2)
        {
            return new InchesOfMercury((p1.BaseUnitValue * p2.BaseUnitValue));
        }

        public static InchesOfMercury operator /(Pressure<T> p1, IPressure p2)
        {
            if (p2.BaseUnitValue == 0)
                throw new DivideByZeroException();

            return new InchesOfMercury((p1.BaseUnitValue / p2.BaseUnitValue));
        }
    }
}
