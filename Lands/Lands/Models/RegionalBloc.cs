namespace Lands.Models
{

    using Newtonsoft.Json;

    public class RegionalBloc
    {
        //Como lo voy a recibir del json - acronym
        [JsonProperty(PropertyName = "acronym")]
        //Como lo voy a llamar internamente - Acronym
        public string Acronym { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
