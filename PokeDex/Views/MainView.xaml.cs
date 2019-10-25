using PokeDex.Entities;
using PokeDex.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace PokeDex.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        List<Pokemon> pokemons = new List<Pokemon>();
        public MainView()
        {
            InitializeComponent();
        }

        private void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TrainerDetailView());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var scanView = new ZXingScannerPage();
            scanView.OnScanResult += ScanView_OnScanResult;
            Navigation.PushAsync(scanView);
        }

        private void ScanView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PopAsync();
                var pokemonId = result.Text;
                if (!string.IsNullOrWhiteSpace(pokemonId))
                {
                    DataService dataService = new DataService();

                    var pokemon = await dataService.GetPokemonAsync(Convert.ToInt32(pokemonId));

                    if (pokemon != null)
                    {
                        pokemons.Add(pokemon);
                        pokemonColllectionView.ItemsSource = pokemons;

                        await TextToSpeech.SpeakAsync(pokemon.Species.FlavorTextEntries.FirstOrDefault(flavor => flavor.Language.Name == "en").FlavorText);
                    }
                }
            });
        }
    }
}