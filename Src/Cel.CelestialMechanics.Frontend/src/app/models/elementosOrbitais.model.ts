export interface ElementosOrbitaisModel {
  nome: string;
  tempo: number;
  longitudeNodoAscendente: number;
  inclinacaoPlanoOrbitalTerra: number;
  argumentoPerielio: number;
  semiEixoMaiorOrbita: number;
  excentricidadeOrbita: number;
  anomaliaMedia: number;
  anomaliaExentrica: number;
  anomaliaVerdadeira: number;
  distanciaPlanetaSol: number;
  coordenadaX: number;
  coordenadaY: number;
  coordenadaZ: number;
  coordenadaLambda: number;
  coordenadaBeta: number;
}
