using Newtonsoft.Json;
using System.Collections.Generic;

namespace PokemonAPI.classes
{
    public class Pokemon
    {
        public class Result
        {
            [JsonProperty("name")]
            public string Name { get; set; }
            [JsonProperty("url")]
            public string Url { get; set; }
        }

        public class Results
        {
            [JsonProperty("resulten")]
            public List<Result> Resulten { get; set; }
        }

        /*public class Example
        {
            public int count { get; set; }
            public string next { get; set; }
            public object previous { get; set; }
            public IList<Result> results { get; set; }
        }*/
    }
}
