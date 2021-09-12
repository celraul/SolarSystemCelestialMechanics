using Cel.CelestialMechanics.Domain.Extensions;
using System;
using System.Diagnostics;

namespace Cel.CelestialMechanics.Domain.Entities
{
    [DebuggerDisplay("valores = {LongitudeNodoAscendente}")]
    public class Planeta
    {
        public string Nome { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public double Tempo { get; private set; }

        /// <summary>
        /// (Ω) Longitude do nodo ascendente - Em graus
        /// </summary>
        public double LongitudeNodoAscendente { get; private set; }
        /// <summary>
        /// (i) Inclinação em relação ao plano orbital da Terra - Em graus
        /// </summary>
        public double InclinacaoPlanoOrbitalTerra { get; private set; }
        /// <summary>
        /// (ω) Argumento de periélio - Em graus
        /// </summary>
        public double ArgumentoPerielio { get; private set; }
        /// <summary>
        /// (a) Semieixo maior da órbita - em Ua
        /// </summary>
        public double SemiEixoMaiorOrbita { get; set; }
        /// <summary>
        /// (e) excentricidade da órbita - admencional
        /// </summary>
        public double ExcentricidadeOrbita { get; private set; }
        /// <summary>
        /// (M) Anomalia média - Em graus
        /// </summary>
        public double AnomaliaMedia { get; private set; }
        /// <summary>
        /// (M) Anomalia média - Em radianos
        /// </summary>
        public double AnomaliaMediaRad { get; private set; }

        /// <summary>
        /// (E) Cálculo da anomalia Excêntrica - Em graus
        /// </summary>
        public double AnomaliaExentrica { get; private set; }
        /// <summary>
        /// (V) Anomalia verdadeira - Em graus
        /// </summary>
        public double AnomaliaVerdadeira { get; private set; }
        /// <summary>
        /// (r) Distância do planeta ao SOl  - em Ua
        /// </summary>
        public double DistanciaPlanetaSol { get; private set; }

        // Coordenadas
        public double CoordenadaX { get; private set; }
        public double CoordenadaY { get; private set; }
        public double CoordenadaZ { get; private set; }
        public double CoordenadaLambda { get; private set; }
        public double CoordenadaBeta { get; private set; }

        public Planeta(string nome)
        {
            Nome = nome;
        }

        public void CalcularTempo(DateTime data)
        {
            int ano = data.Year;
            int mes = data.Month;
            int dia = data.Day;

            double parte1 = 367 * ano;
            double parte2 = Math.Floor((7 * (ano + Math.Floor((mes + 9d) / 12))) / 4);
            double parte3 = Math.Floor((275d * mes) / 9d);

            Tempo = parte1 - parte2 + parte3 + dia - 730530;
        }

        public void CalcularLongitudeDoNodoAscendente(double angulo, double p2)
            => LongitudeNodoAscendente = angulo + (p2 * Tempo);

        public void CalcularInclinacaoPlanoOrbitalTerra(double angulo, double p2)
             => InclinacaoPlanoOrbitalTerra = angulo + (p2 * Tempo);

        public void CalcularArgumentoPerielio(double angulo, double p2)
            => ArgumentoPerielio = (angulo + p2) * Tempo;

        public void CalcularSemiEixoMaiorOrbita(double distancia)
          => SemiEixoMaiorOrbita = distancia; // (au)

        public void CalcularExcentricidadeDaOrbita(double angulo, double p2)
            => ExcentricidadeOrbita = angulo + (p2 * Tempo);

        public void CalcularAnomaliaMedia(double angulo, double angulo2)
        {
            AnomaliaMedia = angulo + (angulo2 * Tempo);
            AnomaliaMediaRad = AnomaliaMedia.ToRad();
        }

        public void CalcularAnomaliaExcentrica()
        {
            // M = E − e sin E
            var E = AnomaliaMediaRad;
            var deltaE = (AnomaliaMediaRad - E) + ExcentricidadeOrbita * Math.Sin(E)
                / 1 - (ExcentricidadeOrbita * Math.Cos(E));

            AnomaliaExentrica = E + deltaE;
        }

        public void CalcularAnomaliaVerdadeira()
        {
            //
            var part1 = (1 + ExcentricidadeOrbita) / (1 - ExcentricidadeOrbita);
            var part2 = Math.Sqrt(part1) * Math.Tan(AnomaliaExentrica / 2);
            AnomaliaVerdadeira = Math.Atan(part2) * 2;
        }

        public void CalcularDistanciaPlanetaSol()
        {
            DistanciaPlanetaSol = SemiEixoMaiorOrbita * (1 - Math.Pow(ExcentricidadeOrbita, 2))
                / (1 + ExcentricidadeOrbita * Math.Cos(AnomaliaVerdadeira));
        }

    }
}