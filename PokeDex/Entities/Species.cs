using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDex.Entities
{
    public class Species
    {
        [JsonProperty("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }
    }
}
