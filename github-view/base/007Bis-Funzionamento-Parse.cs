    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 007Bis-Funzionamento-Parse.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 007Bis_Funzionamento_Parse
    {
        public static void Main()
        {
            
            void Main()
            {
            // Mostro un messaggio all’utente per inserire un numero
            Console.WriteLine("Scrivi un numero con la virgola (es. 7.5):");
            
            // Leggo l’input dalla tastiera (sempre una stringa)
            string input = Console.ReadLine();
            
            // Converto la stringa in numero double usando Parse
            double numeroConvertito = double.Parse(input);
            
            // Stampo il risultato della conversione
            Console.WriteLine($"Hai scritto il numero: {numeroConvertito}");
            
            // Faccio una semplice operazione per dimostrare che ora è un numero vero
            Console.WriteLine($"Il doppio del numero è: {numeroConvertito * 2}");
            
            }
            
        }
    }
}
