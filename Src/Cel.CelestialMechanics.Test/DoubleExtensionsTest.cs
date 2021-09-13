using Cel.CelestialMechanics.Domain.Extensions;
using NUnit.Framework;
using System;

namespace Cel.CelestialMechanics.Test
{
    public class DoubleExtensionsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToRad()
        {
            var value1 = Math.Round(50d.GrausToRad(), 5);
            var value2 = Math.Round(100d.GrausToRad(), 5);
            var value3 = Math.Round(180d.GrausToRad(), 5);
            var value4 = Math.Round(360d.GrausToRad(), 5);

            Assert.AreEqual(0.87266, value1);
            Assert.AreEqual(1.74533, value2);
            Assert.AreEqual(3.14159, value3);
            Assert.AreEqual(6.28319, value4);
        }

        [Test]
        public void RadToGraus()
        {
            var value1 = Math.Round(1d.RadToGraus(), 4);
            var value2 = Math.PI.RadToGraus();
            var value3 = 2 * Math.PI.RadToGraus();

            Assert.AreEqual(57.2958, value1);
            Assert.AreEqual(180, value2);
            Assert.AreEqual(360, value3);
        }

        [Test]
        public void UaToKm()
        {
            Assert.AreEqual(149597870.7, 1d.UaToKm());
            Assert.AreEqual(299195741.4, 2d.UaToKm());
        }
    }
}