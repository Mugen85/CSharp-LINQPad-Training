    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 014-scope-variabili-blocchi-codice.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 014_scope_variabili_blocchi_codice
    {
        public static void Main()
        {
            
            void Main()
            {
            var messaggio = "Fuori dal blocco";
            Console.WriteLine(messaggio);
            
            if (true)
            {
            var dentroIf = "Sono dentro l'if";
            Console.WriteLine(dentroIf);
            }
            
            // Console.WriteLine(dentroIf); // ⚠️ Errore: la variabile non esiste fuori dal blocco
            
            for (var i = 0; i < 3; i++)
            {
            var dentroFor = $"Iterazione {i}";
            Console.WriteLine(dentroFor);
            }
            
            // Console.WriteLine(dentroFor); // ⚠️ Errore: anche questa non è visibile fuori dal for
            
            // -------------------------
            // 🔽 Spiegazione riga per riga
            // -------------------------
            
            // 1. var messaggio = "Fuori dal blocco";
            //    → Variabile dichiarata nel blocco principale. È visibile ovunque sotto questa riga.
            
            // 2. Console.WriteLine(messaggio);
            //    → Stampo la variabile visibile nel blocco principale.
            
            // 3. if (true) { ... }
            //    → Apro un nuovo blocco di codice. Tutto dentro le graffe ha uno scope limitato.
            
            // 4. var dentroIf = "Sono dentro l'if";
            //    → Questa variabile esiste **solo** dentro l'`if`. Fuori da lì non è accessibile.
            
            // 5. Console.WriteLine(dentroIf);
            //    → Stampo correttamente la variabile dentro il blocco.
            
            // 6. // Console.WriteLine(dentroIf);
            //    → Se provo a usarla fuori dal blocco, ottengo un errore di compilazione.
            
            // 7. for (var i = 0; i < 3; i++) { ... }
            //    → Anche il `for` ha un blocco. Le variabili dentro il `for` vivono solo lì.
            
            // 8. var dentroFor = $"Iterazione {i}";
            //    → Questa variabile viene creata e distrutta a ogni ciclo. È temporanea.
            
            // 9. // Console.WriteLine(dentroFor);
            //    → Non posso usarla fuori dal ciclo `for`.
            
            }
            
        }
    }
}
