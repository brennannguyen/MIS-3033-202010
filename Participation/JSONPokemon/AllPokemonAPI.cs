using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace JSONPokemon
{
    class AllPokemonAPI
    {
        public List<PokemonResults> results { get; set; }
    }

    public class PokemonResults
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class PokemonInfo
    {
        public int height { get; set; }
        public int weight { get; set; }
        public images sprites { get; set; }
    }

    public class images
    {
        public string back_default { get; set; }
        public string front_default { get; set; }
        
    }

}
