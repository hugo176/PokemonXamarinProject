using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon.Models
{
    public class SpriteModel
    {

        [JsonProperty("front_default")]
        public string Front_default { get; set; }
    }
}
