using Pokemon.Helpers;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.ViewsModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Array> Pokemons { get; set; }

        public async Task LoadPokemons()
        {
            string url = "https://pokeapi.co/api/v2/pokemon";
            var service = new HttpHelper<PokemonesModel>();
            var pokemones = await service.GetRestServiceDataAsync(url);
            Pokemons = new ObservableCollection<Array>(pokemones.Pokemones);
        }
    }
}
