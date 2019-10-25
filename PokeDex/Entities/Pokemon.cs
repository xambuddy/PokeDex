using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDex.Entities
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonIgnore]
        public Species Species { get; set; }
        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }
    }
}
