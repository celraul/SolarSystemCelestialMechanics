using System;

namespace Cel.CelestialMechanics.Domain.Extensions
{
    public static class DoubleExtensions
    {
        public static double GrausToRad(this double value)
        {
            if (value > 360)
            {
                var voltas = Math.Floor(value / 360);
                value = value - (voltas * 360);
            }

            return (value * (2 * Math.PI)) / 360;
        }

        public static double RadToGraus(this double value)
        {
            return value * (180 / Math.PI);
        }

        public static double UaToKm(this double value)
        {
            var ua = 149597870.7;
            return value * ua;
        }
    }
}
