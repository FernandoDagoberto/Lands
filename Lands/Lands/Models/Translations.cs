namespace Lands.Models
{
    using Newtonsoft.Json;

    public class Translations
    {
        //Como lo voy a recibir del json - de
        [JsonProperty(PropertyName = "de")]
        //Como lo voy a llamar internamente - Germany
        public string Germany { get; set; }

        [JsonProperty(PropertyName = "es")]
        public string Spanich { get; set; }

        [JsonProperty(PropertyName = "fr")]
        public string French{ get; set; }

        [JsonProperty(PropertyName = "ja")]
        public string Japanese { get; set; }

        [JsonProperty(PropertyName = "it")]
        public string Italian { get; set; }

        [JsonProperty(PropertyName = "br")]
        public string Brazilian { get; set; }

        [JsonProperty(PropertyName = "pt")]
        public string Portuges { get; set; }

        [JsonProperty(PropertyName = "nl")]
        public string Dutch { get; set; }

        [JsonProperty(PropertyName = "hr")]
        public string Croatian { get; set; }

        [JsonProperty(PropertyName = "fa")]
        public string Danish { get; set; }

    }
}
