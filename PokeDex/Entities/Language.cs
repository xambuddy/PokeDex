using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDex.Entities
{
    public class Language
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
