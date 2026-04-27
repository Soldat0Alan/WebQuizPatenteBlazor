using System.Text.Json;
using System.Text.Json.Serialization;

namespace Patente
{
    public static class GestioneJson
    {
        /// <summary>
        /// Restituisce la lista delle domande prese dal file JSON
        /// </summary>
        /// <returns></returns>
        public static List<Domanda> LeggiFileDomande()
        {
            string contenutoFile= File.ReadAllText("wwwroot/fileJson/domande.json");
            Console.WriteLine("Tutte le domande sono state importate correttamente!");
            return JsonSerializer.Deserialize<List<Domanda>>(contenutoFile)!;
        }

        /// <summary>
        /// Restituisce la lista degli argomenti presi dal file JSON
        /// </summary>
        /// <returns></returns>
        public static List<Argomento> LeggiFileArgomento()
        {
            string contenutoFile= File.ReadAllText("wwwroot/fileJson/argomenti.json");
            Console.WriteLine("Tutti gli argomenti sono stati importati correttamente!");
            return JsonSerializer.Deserialize<List<Argomento>>(contenutoFile)!;
        }
           
        /// <summary>
        /// Restituisce la lista dei suggerimenti presi dal file JSON
        /// </summary>
        /// <returns></returns>
        public static List<Suggerimento> LeggiFileSuggerimenti()
        {
            string contenutoFile= File.ReadAllText("wwwroot/fileJson/hints.json");
            Console.WriteLine("Tutti i suggerimenti sono stati importati correttamente!");
            return JsonSerializer.Deserialize<List<Suggerimento>>(contenutoFile)!;
        }
           
           
    }
}