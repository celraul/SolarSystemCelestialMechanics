using Cel.CelestialMechanics.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Cel.CelestialMechanics.Domain.Interfaces
{
    public interface IMecanicaSistemaSolarFactory
    {
        List<Planeta> Builder(DateTime date);
    }
}
