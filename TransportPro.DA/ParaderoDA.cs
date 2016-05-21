using System.Linq;
using TransportPro.Entities;
using TransportPro.Entities.Helpers;

namespace TransportPro.DA
{
    public class ParaderoDA
    {
        #region "SINGLETON"
        private static ParaderoDA _instance;

        public static ParaderoDA GetInstance()
        {
            return _instance ?? (_instance = new ParaderoDA());
        }

        #endregion



        #region "METODOS"

        public Paradero[] GetParaderosLinea1()
        {
            return new[]{ new Paradero() { Codigo = "LBrasil1", Coordenada = new Coordenada{Latitud =-12.00109,Longitud = -77.11656}},
                        new Paradero() { Codigo = "LBrasil2", Coordenada = new Coordenada{Latitud =-12.02177,Longitud = -77.10634}},
                        new Paradero() { Codigo = "LBrasil3", Coordenada = new Coordenada{Latitud =-12.0399,Longitud = -77.09913}},
                        new Paradero() { Codigo = "LBrasil4", Coordenada = new Coordenada{Latitud =-12.04771,Longitud = -77.09844}},
                        new Paradero() { Codigo = "LBrasil5", Coordenada = new Coordenada{Latitud =-12.0619,Longitud = -77.09733}},
                        new Paradero() { Codigo = "LCommon1", Coordenada = new Coordenada{Latitud =-12.06928,Longitud = -77.09818}},
                        new Paradero() { Codigo = "LBrasil6", Coordenada = new Coordenada{Latitud =-12.06999,Longitud = -77.09447}},
                        new Paradero() { Codigo = "LBrasil7", Coordenada = new Coordenada{Latitud =-12.0706,Longitud = -77.0919}},
                        new Paradero() { Codigo = "LBrasil8", Coordenada = new Coordenada{Latitud =-12.07606,Longitud = -77.09331}},
                        new Paradero() { Codigo = "LBrasil9", Coordenada = new Coordenada{Latitud =-12.07696,Longitud = -77.09331}},
                        new Paradero() { Codigo = "LBrasil10", Coordenada = new Coordenada{Latitud =-12.08395,Longitud = -77.09651}},
                        new Paradero() { Codigo = "LBrasil11", Coordenada = new Coordenada{Latitud =-12.08569,Longitud = -77.09303}},
                        new Paradero() { Codigo = "LBrasil12", Coordenada = new Coordenada{Latitud =-12.08936,Longitud = -77.08503}},

            };
        }

        public Paradero[] GetParaderosLinea2()
        {
            return new[]{new Paradero() { Codigo = "LBrasil13", Coordenada = new Coordenada{Latitud =-12.00109,Longitud = -77.11656}},
                        new Paradero() { Codigo = "LBrasil14", Coordenada = new Coordenada{Latitud =-12.02177,Longitud = -77.10634}},
                        new Paradero() { Codigo = "LBrasil15", Coordenada = new Coordenada{Latitud =-12.0399,Longitud = -77.09913}},
                        new Paradero() { Codigo = "LBrasil16", Coordenada = new Coordenada{Latitud =-12.04771,Longitud = -77.09844}},
                        new Paradero() { Codigo = "LBrasil17", Coordenada = new Coordenada{Latitud =-12.0619,Longitud = -77.09733}},
                        new Paradero() { Codigo = "LCommon1", Coordenada = new Coordenada{Latitud =-12.06928,Longitud = -77.09818}},
                        new Paradero() { Codigo = "LBrasil18", Coordenada = new Coordenada{Latitud =-12.06999,Longitud = -77.09447}},
                        new Paradero() { Codigo = "LBrasil19", Coordenada = new Coordenada{Latitud =-12.0706,Longitud = -77.0919}},
                        new Paradero() { Codigo = "LBrasil20", Coordenada = new Coordenada{Latitud =-12.07606,Longitud = -77.09331}},
                        new Paradero() { Codigo = "LBrasil21", Coordenada = new Coordenada{Latitud =-12.07801,Longitud = -77.08874}},
                        new Paradero() { Codigo = "LBrasil22", Coordenada = new Coordenada{Latitud =-12.07801,Longitud = -77.08179}},
                        new Paradero() { Codigo = "LBrasil23", Coordenada = new Coordenada{Latitud =-12.08279,Longitud = -77.06763}},
                        new Paradero() { Codigo = "LBrasil24", Coordenada = new Coordenada{Latitud =-12.08598,Longitud = -77.06377}},

            };
        }

        public Paradero[] GetParaderosLinea3()
        {
            return new[]{new Paradero() { Codigo = "LBrasil25", Coordenada = new Coordenada{Latitud =-12.00109,Longitud = -77.11656}},
                        new Paradero() { Codigo = "LBrasil26", Coordenada = new Coordenada{Latitud =-12.02177,Longitud = -77.10634}},
                        new Paradero() { Codigo = "LBrasil27", Coordenada = new Coordenada{Latitud =-12.0399,Longitud = -77.09913}},
                        new Paradero() { Codigo = "LBrasil28", Coordenada = new Coordenada{Latitud =-12.04771,Longitud = -77.09844}},
                        new Paradero() { Codigo = "LBrasil29", Coordenada = new Coordenada{Latitud =-12.0619,Longitud = -77.09733}},
                        new Paradero() { Codigo = "LCommon1", Coordenada = new Coordenada{Latitud =-12.06928,Longitud = -77.09818}},
                        new Paradero() { Codigo = "LBrasil30", Coordenada = new Coordenada{Latitud =-12.04922,Longitud = -77.10634}},
                        new Paradero() { Codigo = "LBrasil31", Coordenada = new Coordenada{Latitud =-12.05451,Longitud = -77.10591}},
                        new Paradero() { Codigo = "LBrasil32", Coordenada = new Coordenada{Latitud =-12.06282,Longitud = -77.10479}},
                        new Paradero() { Codigo = "LBrasil33", Coordenada = new Coordenada{Latitud =-12.06827,Longitud = -77.10411}},

            };
        }

        public Paradero[] GetParaderosLinea4()
        {
            return new[]{ new Paradero() { Codigo = "A", Coordenada = new Coordenada{Latitud = -12.0871251,Longitud = -77.0052117}},
                                   new Paradero() { Codigo = "P1", Coordenada = new Coordenada{Latitud = -12.096093, Longitud = -76.989252}},
                                   new Paradero() { Codigo = "P2", Coordenada = new Coordenada{Latitud = -12.097644, Longitud =  -76.980133}},
                                   new Paradero() { Codigo = "P3", Coordenada = new Coordenada{Latitud = -12.099207, Longitud =  -76.969335}},
                                   new Paradero() { Codigo = "B", Coordenada = new Coordenada{Latitud = -12.103812, Longitud = -76.962198}}
            };
        }

        public Paradero[] GetParaderosLinea5()
        {
            return new[]{ new Paradero() { Codigo = "C", Coordenada = new Coordenada{Latitud = -12.127784, Longitud = -76.991840}},
                                   new Paradero() { Codigo = "P4", Coordenada = new Coordenada{Latitud = -12.109805, Longitud = -76.984211}},
                                   new Paradero() { Codigo = "P2", Coordenada = new Coordenada{Latitud = -12.097644, Longitud =  -76.980133}},
                                   new Paradero() { Codigo = "P5", Coordenada = new Coordenada{Latitud = -12.063234, Longitud =  -76.961095}},
                                   new Paradero() { Codigo = "D", Coordenada = new Coordenada{Latitud = -12.006048, Longitud =  -76.911069}}
            };
        }

        public Paradero[] GetParaderosLinea11()
        {
            return new[]{ new Paradero() { Codigo = "1", Coordenada = new Coordenada{Latitud =-12.06076,Longitud = -77.04214}},
new Paradero() { Codigo = "2", Coordenada = new Coordenada{Latitud =-12.06307,Longitud = -77.04407}},
new Paradero() { Codigo = "3", Coordenada = new Coordenada{Latitud =-12.06517,Longitud = -77.04557}},
new Paradero() { Codigo = "4", Coordenada = new Coordenada{Latitud =-12.06823,Longitud = -77.0481}},
new Paradero() { Codigo = "5", Coordenada = new Coordenada{Latitud =-12.07109,Longitud = -77.05055}},
new Paradero() { Codigo = "6", Coordenada = new Coordenada{Latitud =-12.07411,Longitud = -77.05304}},
new Paradero() { Codigo = "7", Coordenada = new Coordenada{Latitud =-12.077,Longitud = -77.05548}},
new Paradero() { Codigo = "8", Coordenada = new Coordenada{Latitud =-12.07973,Longitud = -77.05767}},
new Paradero() { Codigo = "9", Coordenada = new Coordenada{Latitud =-12.08254,Longitud = -77.05995}},
new Paradero() { Codigo = "10", Coordenada = new Coordenada{Latitud =-12.08653,Longitud = -77.06325}},
new Paradero() { Codigo = "11", Coordenada = new Coordenada{Latitud =-12.08984,Longitud = -77.06591}},
new Paradero() { Codigo = "12", Coordenada = new Coordenada{Latitud =-12.09211,Longitud = -77.06789}},
new Paradero() { Codigo = "13", Coordenada = new Coordenada{Latitud =-12.09396,Longitud = -77.06943}},
new Paradero() { Codigo = "14", Coordenada = new Coordenada{Latitud =-12.09639,Longitud = -77.07132}},
new Paradero() { Codigo = "15", Coordenada = new Coordenada{Latitud =-12.0979,Longitud = -77.06943}},
new Paradero() { Codigo = "16", Coordenada = new Coordenada{Latitud =-12.09899,Longitud = -77.06651}},
new Paradero() { Codigo = "17", Coordenada = new Coordenada{Latitud =-12.10008,Longitud = -77.06316}},
new Paradero() { Codigo = "18", Coordenada = new Coordenada{Latitud =-12.1008,Longitud = -77.06149}},
new Paradero() { Codigo = "19", Coordenada = new Coordenada{Latitud =-12.10193,Longitud = -77.05939}},
new Paradero() { Codigo = "20", Coordenada = new Coordenada{Latitud =-12.10327,Longitud = -77.05814}},
new Paradero() { Codigo = "21", Coordenada = new Coordenada{Latitud =-12.1047,Longitud = -77.0569}},
new Paradero() { Codigo = "22", Coordenada = new Coordenada{Latitud =-12.10621,Longitud = -77.05535}},
new Paradero() { Codigo = "23", Coordenada = new Coordenada{Latitud =-12.10768,Longitud = -77.05381}},
new Paradero() { Codigo = "24", Coordenada = new Coordenada{Latitud =-12.11036,Longitud = -77.05141}},
new Paradero() { Codigo = "25", Coordenada = new Coordenada{Latitud =-12.11242,Longitud = -77.04913}},
new Paradero() { Codigo = "26", Coordenada = new Coordenada{Latitud =-12.11502,Longitud = -77.04668}},
new Paradero() { Codigo = "27", Coordenada = new Coordenada{Latitud =-12.11733,Longitud = -77.04441}},
new Paradero() { Codigo = "28", Coordenada = new Coordenada{Latitud =-12.11892,Longitud = -77.04222}},
new Paradero() { Codigo = "29", Coordenada = new Coordenada{Latitud =-12.11897,Longitud = -77.0396}},
new Paradero() { Codigo = "30", Coordenada = new Coordenada{Latitud =-12.11905,Longitud = -77.0369}},

            };
        }

        public Paradero[] GetParaderosLinea12()
        {
            return new[]{ new Paradero() { Codigo = "31", Coordenada = new Coordenada{Latitud =-12.07109,Longitud = -77.05055}},
new Paradero() { Codigo = "32", Coordenada = new Coordenada{Latitud =-12.07358,Longitud = -77.0495}},
new Paradero() { Codigo = "33", Coordenada = new Coordenada{Latitud =-12.07507,Longitud = -77.04759}},
new Paradero() { Codigo = "34", Coordenada = new Coordenada{Latitud =-12.07518,Longitud = -77.04499}},
new Paradero() { Codigo = "35", Coordenada = new Coordenada{Latitud =-12.07518,Longitud = -77.04499}},
new Paradero() { Codigo = "36", Coordenada = new Coordenada{Latitud =-12.07652,Longitud = -77.04233}},
new Paradero() { Codigo = "37", Coordenada = new Coordenada{Latitud =-12.07977,Longitud = -77.04239}},
new Paradero() { Codigo = "38", Coordenada = new Coordenada{Latitud =-12.08231,Longitud = -77.04568}},
new Paradero() { Codigo = "39", Coordenada = new Coordenada{Latitud =-12.085,Longitud = -77.04885}},
new Paradero() { Codigo = "40", Coordenada = new Coordenada{Latitud =-12.08806,Longitud = -77.05089}},
new Paradero() { Codigo = "41", Coordenada = new Coordenada{Latitud =-12.09287,Longitud = -77.05323}},
new Paradero() { Codigo = "42", Coordenada = new Coordenada{Latitud =-12.0979,Longitud = -77.0558}},
new Paradero() { Codigo = "43", Coordenada = new Coordenada{Latitud =-12.10036,Longitud = -77.05716}},
new Paradero() { Codigo = "44", Coordenada = new Coordenada{Latitud =-12.10327,Longitud = -77.05814}},
            };

        }

        public Paradero[] GetParaderosLinea13()
        {
            return new[]{ new Paradero() { Codigo = "45", Coordenada = new Coordenada{Latitud =-12.07973,Longitud = -77.05767}},
new Paradero() { Codigo = "46", Coordenada = new Coordenada{Latitud =-12.08317,Longitud = -77.05203}},
new Paradero() { Codigo = "47", Coordenada = new Coordenada{Latitud =-12.08231,Longitud = -77.04568}},

            };
        }

        public Paradero[] GetParaderosLinea14()
        {
            return new[]{ new Paradero() { Codigo = "48", Coordenada = new Coordenada{Latitud =-12.06076,Longitud = -77.04214}},
new Paradero() { Codigo = "49", Coordenada = new Coordenada{Latitud =-12.06001,Longitud = -77.0378}},
new Paradero() { Codigo = "50", Coordenada = new Coordenada{Latitud =-12.06467,Longitud = -77.03737}},
new Paradero() { Codigo = "51", Coordenada = new Coordenada{Latitud =-12.07037,Longitud = -77.03647}},
new Paradero() { Codigo = "52", Coordenada = new Coordenada{Latitud =-12.07457,Longitud = -77.03587}},
new Paradero() { Codigo = "53", Coordenada = new Coordenada{Latitud =-12.07961,Longitud = -77.03527}},
new Paradero() { Codigo = "54", Coordenada = new Coordenada{Latitud =-12.08351,Longitud = -77.0345}},
new Paradero() { Codigo = "55", Coordenada = new Coordenada{Latitud =-12.08707,Longitud = -77.03411}},
new Paradero() { Codigo = "56", Coordenada = new Coordenada{Latitud =-12.08976,Longitud = -77.03364}},
new Paradero() { Codigo = "57", Coordenada = new Coordenada{Latitud =-12.09278,Longitud = -77.03317}},
new Paradero() { Codigo = "58", Coordenada = new Coordenada{Latitud =-12.09559,Longitud = -77.03278}},
new Paradero() { Codigo = "59", Coordenada = new Coordenada{Latitud =-12.09874,Longitud = -77.03244}},
new Paradero() { Codigo = "60", Coordenada = new Coordenada{Latitud =-12.1018,Longitud = -77.03184}},
new Paradero() { Codigo = "61", Coordenada = new Coordenada{Latitud =-12.10449,Longitud = -77.03141}},
new Paradero() { Codigo = "62", Coordenada = new Coordenada{Latitud =-12.1068,Longitud = -77.03102}},
new Paradero() { Codigo = "63", Coordenada = new Coordenada{Latitud =-12.10869,Longitud = -77.03068}},
new Paradero() { Codigo = "64", Coordenada = new Coordenada{Latitud =-12.11221,Longitud = -77.03008}},
new Paradero() { Codigo = "65", Coordenada = new Coordenada{Latitud =-12.11683,Longitud = -77.02939}},
new Paradero() { Codigo = "66", Coordenada = new Coordenada{Latitud =-12.11909,Longitud = -77.02926}},
new Paradero() { Codigo = "67", Coordenada = new Coordenada{Latitud =-12.11897,Longitud = -77.03265}},
new Paradero() { Codigo = "68", Coordenada = new Coordenada{Latitud =-12.11905,Longitud = -77.0369}},

            };
        }

        public Paradero[] GetParaderosLinea15()
        {
            return new[]{ new Paradero() { Codigo = "69", Coordenada = new Coordenada{Latitud =-12.1018,Longitud = -77.03184}},
new Paradero() { Codigo = "70", Coordenada = new Coordenada{Latitud =-12.10642,Longitud = -77.03402}},
new Paradero() { Codigo = "71", Coordenada = new Coordenada{Latitud =-12.10915,Longitud = -77.036}},
new Paradero() { Codigo = "72", Coordenada = new Coordenada{Latitud =-12.11104,Longitud = -77.03759}},
new Paradero() { Codigo = "73", Coordenada = new Coordenada{Latitud =-12.11343,Longitud = -77.03935}},
new Paradero() { Codigo = "74", Coordenada = new Coordenada{Latitud =-12.1159,Longitud = -77.04136}},
new Paradero() { Codigo = "75", Coordenada = new Coordenada{Latitud =-12.11892,Longitud = -77.04222}},

            };
        }

        public Paradero GetParaderoMasCerano(Coordenada posicion)
        {
            return LineaDA.GetInstance().lineas.SelectMany(l => l.Paraderos).OrderBy(p => Distance.GetDistance(p.Coordenada, posicion)).First();
        }

        #endregion

    }
}
