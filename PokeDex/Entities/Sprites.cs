using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDex.Entities
{
    public class Sprites
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }
       
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }
    }
}
