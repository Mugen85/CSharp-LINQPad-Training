    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 006-Metodo-ReadLine-Input-da-tastiera.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 006_Metodo_ReadLine_Input_da_tastiera
    {
        public static void Main()
        {
            
            void Main()
            {
            // Mostro un messaggio per chiedere il nome all'utente
            Console.Write("Come ti chiami? ");
            
            // Leggo il nome inserito da tastiera
            string nome = Console.ReadLine();
            
            //Metodo più vecchio, ma utilizzabile
            //Console.WriteLine("Piacere di conoscerti, " + nome + "!");
            
            // Saluto usando l'interpolazione di stringa
            Console.WriteLine($"Piacere di conoscerti, {nome}!");
            
            }
            
        }
    }
}
