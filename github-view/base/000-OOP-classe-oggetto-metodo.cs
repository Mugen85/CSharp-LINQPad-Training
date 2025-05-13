    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente
    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.
    // File sorgente: 000-OOP-classe-oggetto-metodo.linq
    // Data generazione: 2025-05-13 15:00:05
namespace GeneratedSnippets
{
    public class 000_OOP_classe_oggetto_metodo
    {
        public static void Main()
        {
            
            void Main()
            {
            // Creazione di un oggetto reale (istanza) a partire dalla classe Auto
            var miaAuto = new Auto();
            
            // Assegno un valore alla proprietà "Modello" dell'oggetto
            miaAuto.Modello = "Fiat Panda";
            
            // Chiamo il metodo "AvviaMotore" dell'oggetto usando il punto
            miaAuto.AvviaMotore();
            }
            
            // Definizione della classe Auto
            class Auto
            {
            // Proprietà: una stringa che rappresenta il modello dell'auto
            public string Modello;
            
            // Metodo: stampa una frase usando la proprietà
            public void AvviaMotore()
            {
            Console.WriteLine($"L'auto {Modello} ha avviato il motore.");
            }
            }
            
            // 1. class Auto
            //    → Definisce una nuova classe chiamata "Auto"
            
            // 2. public string Modello;
            //    → Proprietà pubblica che conterrà il modello dell’auto (es. "Fiat Panda")
            
            // 3. public void AvviaMotore() { ... }
            //    → Metodo pubblico che stampa un messaggio quando viene chiamato
            
            // 4. var miaAuto = new Auto();
            //    → Creo un oggetto reale chiamato "miaAuto" partendo dalla classe Auto
            
            // 5. miaAuto.Modello = "Fiat Panda";
            //    → Assegno il valore "Fiat Panda" alla proprietà Modello dell’oggetto
            
            // 6. miaAuto.AvviaMotore();
            //    → Chiamo il metodo definito nella classe. Il punto serve per accedere ai membri dell’oggetto
        }
    }
}
