    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 016-errori-compilazione-vs-runtime.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 016_errori_compilazione_vs_runtime
    {
        public static void Main()
        {
            
            void Main()
            {
            // ✅ Codice corretto, compilabile e funzionante
            var numero = 10;
            Console.WriteLine("Numero: " + numero);
            
            // ❌ Errore di compilazione (decommenta per provarlo)
            // var numero = "dieci"; // ⚠️ ERRORE: stai ridefinendo la variabile con tipo diverso
            
            // ❌ Altro errore di compilazione (decommenta per provarlo)
            // Console.WriteLin("Ciao"); // ⚠️ ERRORE: hai scritto male il nome del metodo (manca la "e")
            
            // ❌ Errore di runtime (decommenta per provarlo)
            // var input = "non è un numero";
            // var valore = int.Parse(input); // ⚠️ ERRORE a runtime: il testo non è convertibile in numero
            
            // -------------------------
            // 🔽 Spiegazione riga per riga
            // -------------------------
            
            // 1. var numero = 10;
            //    → Variabile dichiarata correttamente. Tipo intero dedotto da "10".
            
            // 2. Console.WriteLine("Numero: " + numero);
            //    → Stampa correttamente il numero. Nessun errore.
            
            // 3. // var numero = "dieci";
            //    → Errore di compilazione: hai già dichiarato "numero" come int, non puoi riassegnarlo come string.
            
            // 4. // Console.WriteLin("Ciao");
            //    → Errore di compilazione: hai scritto male "WriteLine". Il compilatore non trova il metodo.
            
            // 5. var input = "non è un numero";
            //    → Simulo un input testuale che non è un numero valido.
            
            // 6. int.Parse(input);
            //    → Errore a runtime: il compilatore accetta la sintassi, ma il programma **si blocca in esecuzione** perché non riesce a convertire.
            
            }
            
        }
    }
}
