    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 008-parse-if-else-giudizio-voto.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 008_parse_if_else_giudizio_voto
    {
        public static void Main()
        {
            
            void Main()
            {
            // Mostro un messaggio per richiedere il voto
            Console.WriteLine("Inserisci il tuo voto (da 0 a 10):");
            
            // Leggo l’input dell’utente come stringa
            string inputVoto = Console.ReadLine();
            
            // Converto l’input da stringa a numero con la virgola
            double voto = double.Parse(inputVoto);
            
            // Controllo se il voto è maggiore o uguale a 9
            if (voto >= 9)
            {
            // Se il voto è almeno 9, stampo "Ottimo!"
            Console.WriteLine("Ottimo!");
            }
            // Controllo se il voto è almeno 7 (ma meno di 9)
            else if (voto >= 7)
            {
            // Se è compreso tra 7 e 8.99, stampo "Buono"
            Console.WriteLine("Buono");
            }
            // Controllo se il voto è almeno 6 (ma meno di 7)
            else if (voto >= 6)
            {
            // Se è compreso tra 6 e 6.99, stampo "Sufficiente"
            Console.WriteLine("Sufficiente");
            }
            // Tutti i voti inferiori a 6 sono considerati insufficienti
            else
            {
            // Stampo "Insufficiente"
            Console.WriteLine("Insufficiente");
            }
            
            }
            
        }
    }
}
