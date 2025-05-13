    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 017-const-valori-immutabili.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 017_const_valori_immutabili
    {
        public static void Main()
        {
            
            void Main()
            {
            const double PiGreco = 3.1416;
            Console.WriteLine($"Valore di PiGreco: {PiGreco}");
            
            var raggio = 5;
            var area = PiGreco * raggio * raggio;
            Console.WriteLine($"Area del cerchio con raggio {raggio}: {area}");
            
            // ❌ Errore se provi a cambiare una costante (decommenta per provarlo)
            // PiGreco = 3.14; // ⚠️ Errore: non puoi assegnare un nuovo valore a una costante
            
            // -------------------------
            // 🔽 Spiegazione riga per riga
            // -------------------------
            
            // 1. const double PiGreco = 3.1416;
            //    → Dichiaro una costante chiamata "PiGreco" di tipo double. Non potrà mai essere cambiata.
            
            // 2. Console.WriteLine($"Valore di PiGreco: {PiGreco}");
            //    → Stampo il valore della costante. Funziona come una variabile normale, ma non modificabile.
            
            // 3. var raggio = 5;
            //    → Variabile normale. Il raggio può cambiare.
            
            // 4. var area = PiGreco * raggio * raggio;
            //    → Calcolo l'area del cerchio usando la formula con la costante.
            
            // 5. Console.WriteLine(...);
            //    → Mostro il risultato del calcolo.
            
            // 6. // PiGreco = 3.14;
            //    → Se provi a modificare una costante, ottieni **un errore di compilazione**.
            
            }
            
        }
    }
}
