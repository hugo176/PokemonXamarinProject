using Newtonsoft.Json;
using Pokemon.Models;
using Pokemon.ViewsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pokemon
{
    public partial class MainPage : ContentPage
    {
        public MainPageViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }
        public async  void OnClickButton(object sender, EventArgs e)
        {

            PokemonModel pokemon = await ViewModel.LoadPokemon();
            Console.WriteLine("--------------------------------------------");
            
            BindingContext = pokemon;
            Console.WriteLine("Click");
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = new MainPageViewModel();
            BindingContext = ViewModel;
            await ViewModel.LoadPokemon();
        }
    }
}
