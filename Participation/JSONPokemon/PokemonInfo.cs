using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONPokemon
{
    class PokemonInfo
    {
        public int height { get; set; }
        public int weight { get; set; }
        public sprites images { get; set; }
    }
    public class sprites
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
    }
}
