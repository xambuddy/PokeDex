using Newtonsoft.Json;
using PokeDex.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex.Services
{
    public class DataService
    {
        static HttpClient httpClient = new HttpClient();
        readonly string serverUrl = "https://pokeapi.co/api/v2";

        public async Task<Pokemon> GetPokemonAsync(int pokemonId)
        {
            var infoJson = await httpClient.GetStringAsync($"{serverUrl}/pokemon/{pokemonId}");
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(infoJson);

            if(pokemon != null)
            {
                pokemon.Species = await GetPokemonSpeciesAsync(pokemonId);
            }

            return pokemon;
        }

        private async Task<Species> GetPokemonSpeciesAsync(int pokemonId)
        {
            var infoJson = await httpClient.GetStringAsync($"{serverUrl}/pokemon-species/{pokemonId}");
            var pokemonSpecies = JsonConvert.DeserializeObject<Species>(infoJson);

            return pokemonSpecies;
        }
    }
}
