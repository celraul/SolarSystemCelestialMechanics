using System;

namespace Cel.CelestialMechanics.Domain.Extensions
{
    public static class DoubleExtensions
    {
        public static double ToRad(this double value)
        {
            if (value > 360)
            {
                var voltas = Math.Floor(value / 360);
                value = value - (voltas * 360) ;
            }

            return (value * (2 * Math.PI)) / 360;
        }
    }
}
