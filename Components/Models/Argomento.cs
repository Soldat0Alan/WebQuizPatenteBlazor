
using System.Text.Json.Serialization;

namespace Patente
{
    public class Argomento
    {
        [JsonPropertyName("id_chapter")]
        public int IdCapitolo {get; set;}

        [JsonPropertyName("descrizione")]
        public string Descrizione {get; set;} ="";

        public override string ToString()
        {
            return $"{IdCapitolo}) {Descrizione}.";
        }
    }
}