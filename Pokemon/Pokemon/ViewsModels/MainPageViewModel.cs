using Pokemon.Helpers;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Pokemon.ViewsModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Array> SinglePokemon { get; set; }
        public ICommand SearchCommand { get; set;}

        public PokemonModel BPokemon { get; set; }
        public MainPageViewModel()
        {
            SearchCommand = new Command(async (text) =>
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{text}";
                var service = new HttpHelper<PokemonModel>();
                var pokemon = await service.GetRestServiceDataAsync(url);
                BPokemon = pokemon;
                Console.Write(BPokemon);
            }
            );
        }
        public async Task<PokemonModel> LoadPokemon()
        {
            try
            {
                string url = "https://pokeapi.co/api/v2/pokemon/bulbasaur";
                var service = new HttpHelper<PokemonModel>();
                var pokemon = await service.GetRestServiceDataAsync(url);
                return pokemon;
                Console.Write("-----------------------------------------------------------");
                Console.WriteLine(pokemon.Id);
                
            }
            catch (Exception ex)
            {
                Console.Write("-----------------------------------------------------------");
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return null;
        }
    }
}
