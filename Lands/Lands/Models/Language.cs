namespace Lands.Models
{
    using Newtonsoft.Json;

    public class Language
    {
        //Como lo voy a recibir del json - iso639_1
        [JsonProperty(PropertyName = "iso639_1")]
        //Como lo voy a llamar internamente - Iso6391
        public string Iso6391 { get; set; }

        [JsonProperty(PropertyName = "iso639_2")]
        public string Iso6392 { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "nativeName")]
        public string NativeName { get; set; }
    }
}
