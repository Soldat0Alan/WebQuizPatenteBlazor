using System.Text.Json.Serialization;

namespace Patente
{
    public class Suggerimento
    {
        [JsonPropertyName("result")]
        public string Risultato {get;  set;} = "";

        [JsonPropertyName("id")]
        public int Id {get;  set;}

        [JsonPropertyName("title")]
        public string Titolo {get;  set;} = "";

        [JsonPropertyName("description")]
        public string Descrizione {get;  set;} = "";

        

    }
}