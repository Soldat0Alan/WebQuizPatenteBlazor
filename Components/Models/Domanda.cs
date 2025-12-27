using System.Text.Json.Serialization;

namespace Patente
{
    public class Domanda
    {
        [JsonPropertyName("id")]
        public int Id {get;  set;}

        [JsonPropertyName("id_argument")]
        public string Id_Argomento {get;  set;} = "";

        [JsonPropertyName("image")]
        public int Immagine {get;  set;}

        [JsonPropertyName("answer")]
        public int RispostaQuiz {get;  set;}

        [JsonPropertyName("question")]
        public string DomandaQuiz {get;  set;} = "";

        [JsonPropertyName("type")]
        public string Tipo {get;  set;} = "";

        [JsonPropertyName("language")]
        public string Lingua {get;  set;} = "";

        [JsonPropertyName("theory")]
        public int Teoria {get;  set;}
        
        [JsonPropertyName("id_chaper")]
        public int Id_Capitolo {get;  set;}

        [JsonPropertyName("userAnswer")]
        public int RispostaUtente {get;  set;}
    }
}