using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDex.Entities
{
    public class FlavorTextEntry
    {
        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }
        [JsonProperty("language")]
        public Language Language { get; set; }
    }
}
