using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDex.Entities
{
    public class FlavorTextEntry
    {
        public string flavor_text { get; set; }
        public Language language { get; set; }
        public Version version { get; set; }
    }
}
