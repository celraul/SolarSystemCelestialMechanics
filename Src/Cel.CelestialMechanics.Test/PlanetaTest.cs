using Cel.CelestialMechanics.Domain.Entities;
using Cel.CelestialMechanics.Services;
using Cel.CelestialMechanics.Services.Factories;
using NUnit.Framework;
using System;

namespace Cel.CelestialMechanics.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Planeta_CalcularTempo()
        {
            var terra = new Planeta("Terra");
            var date = new DateTime(2197, 9, 2, 5, 25, 0);
            terra.CalcularTempo(date);

            Assert.IsTrue(terra.Tempo == 72200);
        }


        [Test]
        public void MecanicaSistemaSolarFactory_Builder()
        {
            var factory = new MecanicaSistemaSolarFactory();
            var date = new DateTime(2197, 9, 2, 5, 25, 0);

            var planetas = factory.Builder(date);

            Assert.IsNotNull(planetas);
        }
    }
}