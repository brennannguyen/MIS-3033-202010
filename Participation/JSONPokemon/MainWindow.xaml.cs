using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSONPokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Step 2
            AllPokemonAPI pokemonAPI;
            //Step 1 + create classes
            using (var client = new HttpClient())
            {
                string allPokemonUrl = @"https://pokeapi.co/api/v2/pokemon?limit=150&offset=0";
                
                //Calling the Webservice, Async ensures it doesn't come back without our results.
                string json = client.GetStringAsync(allPokemonUrl).Result;

                //Step 4 after adding newton soft nuget package.
                pokemonAPI = JsonConvert.DeserializeObject<AllPokemonAPI>(json);

            }
            //Step 5 adding results
            foreach (var poke in pokemonAPI.results)
            {
                cboPokemons.Items.Add(poke);
            }
            //Need event for selection changed and 
        }

        private void cboPokemons_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PokemonResults selectedPokemon = (PokemonResults)cboPokemons.SelectedItem;
            PokemonInfo pokemoninfoAPI;
            string pokemonurl = selectedPokemon.url;
            using (var client = new HttpClient())
            {
                string jsondetails = client.GetStringAsync(pokemonurl).Result;
                pokemoninfoAPI = JsonConvert.DeserializeObject<PokemonInfo>(jsondetails);
            }

            foreach (var info in pokemoninfoAPI.images)
            {
                
            }


        }
    }
}
