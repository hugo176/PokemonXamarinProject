using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Models
{
    class PokemonesModel
    {
        [JsonProperty("results")]
        public PokemonModel[] Pokemones{ get; set; }
}
}
