    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 007-Media-numeri-con-parse.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 007_Media_numeri_con_parse
    {
        public static void Main()
        {
            
            void Main()
            {
            // Chiedo all’utente di inserire il primo numero
            Console.WriteLine("Inserisci il primo numero:");
            double numero1 = double.Parse(Console.ReadLine());  // Converto la stringa in numero
            
            // Chiedo il secondo numero
            Console.WriteLine("Inserisci il secondo numero:");
            double numero2 = double.Parse(Console.ReadLine());  // Converto anche questo
            
            // Chiedo il terzo numero
            Console.WriteLine("Inserisci il terzo numero:");
            double numero3 = double.Parse(Console.ReadLine());  // Idem
            
            // Mostro i numeri inseriti usando string interpolation
            Console.WriteLine($"Hai inserito: {numero1}, {numero2}, {numero3}");
            
            // Calcolo la media dei tre numeri
            double media = (numero1 + numero2 + numero3) / 3;
            
            // Mostro il risultato finale
            Console.WriteLine($"La media dei tre numeri è: {media}");
            }
            
        }
    }
}
