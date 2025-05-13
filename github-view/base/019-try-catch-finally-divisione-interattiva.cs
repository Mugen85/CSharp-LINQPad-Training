    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 019-try-catch-finally-divisione-interattiva.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 019_try_catch_finally_divisione_interattiva
    {
        public static void Main()
        {
            
            void Main()
            {
            Console.WriteLine("▶ Avvio programma di divisione guidata");
            
            Console.Write("Inserisci il dividendo (numero intero): ");
            string inputDividendo = Console.ReadLine();
            Console.WriteLine($"✅ Hai inserito il dividendo: {inputDividendo}");
            
            Console.Write("Inserisci il divisore (numero intero): ");
            string inputDivisore = Console.ReadLine();
            Console.WriteLine($"✅ Hai inserito il divisore: {inputDivisore}");
            
            Console.WriteLine("\n📌 Tentativo di eseguire la divisione...");
            
            try
            {
            int dividendo = int.Parse(inputDividendo);
            int divisore = int.Parse(inputDivisore);
            
            int risultato = dividendo / divisore;
            Console.WriteLine($"\n✅ Risultato della divisione: {dividendo} / {divisore} = {risultato}");
            }
            catch (FormatException)
            {
            Console.WriteLine("\n❌ Errore di formato: uno dei valori inseriti non è un numero intero valido.");
            }
            catch (DivideByZeroException)
            {
            Console.WriteLine("\n❌ Errore: hai provato a dividere per zero, operazione non permessa.");
            }
            catch (Exception ex)
            {
            Console.WriteLine($"\n❌ Errore imprevisto: {ex.Message}");
            }
            finally
            {
            Console.WriteLine("\nℹ️ Fine del tentativo di divisione. Questo messaggio appare sempre.");
            }
            
            Console.WriteLine("\n🏁 Programma terminato.");
            }
        }
    }
}
