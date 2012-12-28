using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public abstract class Unit<T> : IUnit, IComparable<T>, IEquatable<T> 
        where T : IUnit
    {
        /// <summary>
        /// The actual value of the unit instance
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// The type of the base unit
        /// </summary>
        public abstract Type BaseUnit { get; }

        /// <summary>
        /// The value of this instance in base units
        /// </summary>
        public virtual double BaseUnitValue { get { return Factor * Value; } }

        /// <summary>
        /// Factor relative to meters
        /// </summary>
        public double Factor { get; protected set; }

        /// <summary>
        /// Label for the given unit
        /// </summary>
        public string Label { get; protected set; }

        /// <summary>
        /// Abbreviation for the given unit
        /// </summary>
        public string Symbol { get; protected set; }

        //
        // IComparable<T>

        public int CompareTo(T other)
        {
            if (this.BaseUnitValue > other.BaseUnitValue)
                return 1;
            else if (this.BaseUnitValue < other.BaseUnitValue)
                return -1;
            else
                return 0;
        }

        //
        // IEquatable<T>

        public bool Equals(T other)
        {
            return this.BaseUnitValue == other.BaseUnitValue;
        }
    }
}
