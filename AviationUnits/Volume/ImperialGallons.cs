using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AviationUnits.Contracts;

namespace AviationUnits
{
    public sealed class ImperialGallons : Volume<ImperialGallons>
    {
        public ImperialGallons()
            : this(0.0)
        {

        }

        public ImperialGallons(IVolume volume)
            : this(volume.To<ImperialGallons>().Value)
        {

        }

        public ImperialGallons(double value)
        {
            this.Factor = Factors.LitersPerImperialGallon;
            this.Label = "Imperial Gallons";
            this.Symbol = "gal(uk)";
            this.Value = value;
        }

        public static implicit operator ImperialGallons(double value)
        {
            return new ImperialGallons(value);
        }
    }
}
