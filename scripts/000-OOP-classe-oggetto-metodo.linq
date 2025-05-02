<Query Kind="Program" />

/*
✅ Obiettivo  
Capire cosa sono una classe, un oggetto e un metodo.  
Creare un oggetto da una classe e usarne un metodo tramite il punto (`.`).

💡 Concetti  
- class → definisce un nuovo tipo (modello)  
- new → crea un oggetto (istanza) di una classe  
- metodo → azione definita dentro una classe  
- punto `.` → serve per accedere a metodi e proprietà

🧠 Focus tecnico  
Tutto in C# gira intorno alle **classi** e agli **oggetti**.  
Con `new` creiamo un oggetto reale da una classe.  
Con `.` possiamo usare le sue azioni (metodi) o leggere/scrivere i suoi dati (proprietà).
*/

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
