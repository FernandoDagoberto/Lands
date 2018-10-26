namespace Lands.Models
{
    using Newtonsoft.Json;

    public class Currency
    {
        //Como lo voy a recibir del json - code
        [JsonProperty(PropertyName="code")]
        //Como lo voy a llamar internamente - Code
        public string Code { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "symbol")]
        public string Symbol { get; set; }
    }
}
