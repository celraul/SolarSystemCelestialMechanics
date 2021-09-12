using Cel.CelestialMechanics.Domain.Entities;
using Cel.CelestialMechanics.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Cel.CelestialMechanics.Services.Factories
{
    public class MecanicaSistemaSolarFactory : IMecanicaSistemaSolarFactory
    {
        public List<Planeta> Builder(DateTime date)
        {
            var planetas = new List<Planeta>();

            planetas.Add(MecanicaMercurio(date));
            planetas.Add(MecanicaVenus(date));
            planetas.Add(MecanicaTerra(date));
            planetas.Add(MecanicaMarte(date));
            planetas.Add(MecanicaJupter(date));
            planetas.Add(MecanicaSaturno(date));
            planetas.Add(MecanicaUrano(date));
            planetas.Add(MecanicaNetuno(date));

            return planetas;
        }

        private Planeta MecanicaMercurio(DateTime date)
        {
            // Mercurio 
            var planeta = new Planeta("Mercúrio");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(48.3313, 3.24587 * Math.Pow(10, -5));
            planeta.CalcularInclinacaoPlanoOrbitalTerra(7.0047, 5.00 * Math.Pow(10, -8));
            planeta.CalcularArgumentoPerielio(29.1241, 1.01444 * Math.Pow(10, -5));
            planeta.CalcularSemiEixoMaiorOrbita(0.387098);
            planeta.CalcularExcentricidadeDaOrbita(0.205635, 5.59 * Math.Pow(10, -10));
            planeta.CalcularAnomaliaMedia(168.6562, 4.0923344368);
            
            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }

        private Planeta MecanicaVenus(DateTime date)
        {
            var planeta = new Planeta("Vênus");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(76.6799, 2.46590 * Math.Pow(10, -5));
            planeta.CalcularInclinacaoPlanoOrbitalTerra(3.3946, 2.75 * Math.Pow(10, -8));
            planeta.CalcularArgumentoPerielio(54.8910, 1.38374 * Math.Pow(10, -5));
            planeta.CalcularSemiEixoMaiorOrbita(0.723330);
            planeta.CalcularExcentricidadeDaOrbita(0.006773, 1.302 * Math.Pow(10, -9));
            planeta.CalcularAnomaliaMedia(48.0052, 1.6021302244);

            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }

        private Planeta MecanicaTerra(DateTime date)
        {
            var planeta = new Planeta("Terra");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(0, 0);
            planeta.CalcularInclinacaoPlanoOrbitalTerra(0, 0);
            planeta.CalcularArgumentoPerielio(282.9404, 4.70935 * Math.Pow(10, -5));
            planeta.CalcularSemiEixoMaiorOrbita(1.0);
            planeta.CalcularExcentricidadeDaOrbita(0.016709, 1.0151 * Math.Pow(10, -9));
            planeta.CalcularAnomaliaMedia(356.0470, 0.9856002585);

            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }

        private Planeta MecanicaMarte(DateTime date)
        {
            var planeta = new Planeta("Marte");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(49.5574, 2.11081 * Math.Pow(10, -5));
            planeta.CalcularInclinacaoPlanoOrbitalTerra(1.8497, 1.78 * Math.Pow(10, -8));
            planeta.CalcularArgumentoPerielio(286.5016, 2.92961 * Math.Pow(10, -5));
            planeta.CalcularSemiEixoMaiorOrbita(1.523688);
            planeta.CalcularExcentricidadeDaOrbita(0.093405, 2.516 * Math.Pow(10, -9));
            planeta.CalcularAnomaliaMedia(18.6021, 0.5240207766);

            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }

        private Planeta MecanicaJupter(DateTime date)
        {
            var planeta = new Planeta("Júpter");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(100.4542, 2.76854 * Math.Pow(10, -5));
            planeta.CalcularInclinacaoPlanoOrbitalTerra(1.3030, 1.557 * Math.Pow(10, -7));
            planeta.CalcularArgumentoPerielio(273.8777, 1.64505 * Math.Pow(10, -5));
            planeta.CalcularSemiEixoMaiorOrbita(5.20256);
            planeta.CalcularExcentricidadeDaOrbita(0.048498, 4.469 * Math.Pow(10, -9));
            planeta.CalcularAnomaliaMedia(19.8950, 0.0830853001);

            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }

        private Planeta MecanicaSaturno(DateTime date)
        {
            var planeta = new Planeta("Saturno");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(113.6634, 2.38980 * Math.Pow(10, -5));
            planeta.CalcularInclinacaoPlanoOrbitalTerra(2.4886, 1.081 * Math.Pow(10, -7));
            planeta.CalcularArgumentoPerielio(339.3939, 2.97661 * Math.Pow(10, -5));
            planeta.CalcularSemiEixoMaiorOrbita(9.55475);
            planeta.CalcularExcentricidadeDaOrbita(0.055546, 9.499 * Math.Pow(10, -9));
            planeta.CalcularAnomaliaMedia(316.9670, 0.0334442282);

            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }

        private Planeta MecanicaUrano(DateTime date)
        {
            var planeta = new Planeta("Urano");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(74.0005, 1.3978 * Math.Pow(10, -5));
            planeta.CalcularInclinacaoPlanoOrbitalTerra(0.7733, 1.9 * Math.Pow(10, -8));
            planeta.CalcularArgumentoPerielio(96.6612, 3.0565 * Math.Pow(10, -5));
            planeta.CalcularSemiEixoMaiorOrbita(19.18171 + ((1.55 * Math.Pow(10, -8)) * planeta.Tempo)); // calculo diferente
            planeta.CalcularExcentricidadeDaOrbita(0.047318, 7.45 * Math.Pow(10, -9));
            planeta.CalcularAnomaliaMedia(142.5905, 0.011725806);

            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }

        private Planeta MecanicaNetuno(DateTime date)
        {
            var planeta = new Planeta("Netuno");

            planeta.CalcularTempo(date);

            planeta.CalcularLongitudeDoNodoAscendente(131.7806, 3.0173 * Math.Pow(10, -5));
            planeta.CalcularInclinacaoPlanoOrbitalTerra(1.7700, 2.55 * Math.Pow(10, -7));
            planeta.CalcularArgumentoPerielio(272.8461, 6.027 * Math.Pow(10, -6));
            planeta.CalcularSemiEixoMaiorOrbita(30.05826 + ((3.313 * Math.Pow(10, -8)) * planeta.Tempo)); // calculo diferente
            planeta.CalcularExcentricidadeDaOrbita(0.008606, 2.15 * Math.Pow(10, -9));
            planeta.CalcularAnomaliaMedia(260.2471, 0.005995147);

            planeta.CalcularAnomaliaExcentrica();
            planeta.CalcularAnomaliaVerdadeira();
            planeta.CalcularDistanciaPlanetaSol();

            planeta.calcularCoordenadaX();
            planeta.calcularCoordenadaY();
            planeta.calcularCoordenadaZ();
            planeta.calcularCoordenadaLambda();
            planeta.calcularCoordenadaBeta();

            return planeta;
        }
    }
}
