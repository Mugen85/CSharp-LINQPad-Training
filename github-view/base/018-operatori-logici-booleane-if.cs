    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 018-operatori-logici-booleane-if.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 018_operatori_logici_booleane_if
    {
        public static void Main()
        {
            
            void Main()
            {
            var eta = 25;
            var haPatente = true;
            var haSoldi = false;
            
            if (eta >= 18 && haPatente)
            {
            Console.WriteLine("Puoi guidare.");
            }
            
            if (eta < 18 || !haPatente)
            {
            Console.WriteLine("Non puoi guidare.");
            }
            
            if (!haSoldi)
            {
            Console.WriteLine("Non hai soldi per la benzina.");
            }
            
            // -------------------------
            // 🔽 Spiegazione riga per riga
            // -------------------------
            
            // 1. var eta = 25;
            //    → Variabile che rappresenta l’età della persona.
            
            // 2. var haPatente = true;
            //    → Booleano che dice se ha la patente o no.
            
            // 3. var haSoldi = false;
            //    → Booleano che dice se ha soldi o no.
            
            // 4. if (eta >= 18 && haPatente)
            //    → Condizione vera solo se entrambe le cose sono vere: maggiore di 18 **e** con patente.
            
            // 5. Console.WriteLine("Puoi guidare.");
            //    → Viene stampato solo se la condizione precedente è vera.
            
            // 6. if (eta < 18 || !haPatente)
            //    → Condizione vera se almeno una delle due è vera: minorenne **oppure** senza patente.
            
            // 7. Console.WriteLine("Non puoi guidare.");
            //    → Viene eseguito se la condizione è vera.
            
            // 8. if (!haSoldi)
            //    → Il punto esclamativo `!` **nega** il valore. Quindi entra se `haSoldi` è false.
            
            // 9. Console.WriteLine("Non hai soldi per la benzina.");
            //    → Stampato se l’utente non ha soldi.
            
            }
            
        }
    }
}
