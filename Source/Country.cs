using System.Collections.Generic;
using System.Linq;

namespace Codenation.Challenge
{
    public class Country
    {
        public State[] Top10StatesByArea()
        {
            var top10 = GetBrazilianStates().OrderByDescending(state => state.Territory).Take(10);

            return top10.ToArray();
        }

        private List<State> GetBrazilianStates()
        {
            return new List<State>()
            {
                new State("Acre", "AC") { Territory = 164123.040 },
                new State("Alagoas", "AL") { Territory = 27778.506 },
                new State("Amap�", "AP") { Territory = 142828.521 },
                new State("Amazonas", "AM") { Territory = 1559159.148 },
                new State("Bahia", "BA") { Territory = 564733.177 },
                new State("Cear�", "CE") { Territory = 148920.472 },
                new State("Distrito Federal", "DF") { Territory = 5779.999 },
                new State("Esp�rito Santo", "ES") { Territory = 46095.583 },
                new State("Goi�s", "GO") { Territory = 340111.783 },
                new State("Maranh�o", "MA") { Territory = 331937.45 },
                new State("Mato Grosso", "MT") { Territory = 903366.192 },
                new State("Mato Grosso do Sul", "MS") { Territory = 357145.532 },
                new State("Minas Gerais", "MG") { Territory = 586522.122 },
                new State("Par�", "PA") { Territory = 1247954.666 },
                new State("Para�ba", "PB") { Territory = 56585 },
                new State("Paran�", "PR") { Territory = 199307.922 },
                new State("Pernambuco", "PE") { Territory = 98311.616 },
                new State("Piau�", "PI") { Territory = 251577.738 },
                new State("Rio de Janeiro", "RJ") { Territory = 43780.172 },
                new State("Rio Grande do Norte", "RN") { Territory = 52811.047 },
                new State("Rio Grande do Sul", "RS") { Territory = 281730.223 },
                new State("Rond�nia", "RO") { Territory = 237590.547 },
                new State("Roraima", "RR") { Territory = 224300.506 },
                new State("Santa Catarina", "SC") { Territory = 95736.165 },
                new State("S�o Paulo", "SP") { Territory = 248222.362 },
                new State("Sergipe", "SE") { Territory = 21915.116 },
                new State("Tocantins", "TO") { Territory = 277720.52 },
            };
        }
    }
}
