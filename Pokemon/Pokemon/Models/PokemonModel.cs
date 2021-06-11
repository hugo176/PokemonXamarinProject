using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Models
{
    public class PokemonModel
    {
        //Array con un objeto cuyas propieades son "name" y "url
        [JsonProperty("forms")]
        public string[] Forms { get; set; }

        //id
        [JsonProperty("id")]
        public string Id { get; set; }

        /*Array con objetos, cada obejto es una habilidad. Cada obejeto tiene tres propieades "ability, is_hidden, slot", 
         * la propiedad ability es un objeto cuyas propiedades son "name" y "url
         * */

        [JsonProperty("abilities")]
        public string[] Abilities { get; set; }

        /**/
        [JsonProperty("sprites")]
        public object Sprites { get; set; }
    }
}
