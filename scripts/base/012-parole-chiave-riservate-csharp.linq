<Query Kind="Program" />

void Main()
{	
	// ✅ Esempio valido: uso una parola normale come nome di variabile
	var numero = 5;
	Console.WriteLine(numero);
	
	// ❌ Esempio NON valido (provoca errore): sto cercando di usare "int" come nome
	// var int = 10;     // ⚠️ Errore: "int" è una parola riservata
	
	// ✅ Se proprio volessi usare una parola riservata (sconsigliato!), potrei usare @
	// var @int = 10;   // Valido ma sconsigliato, perché confonde
	
	// Mostro una parola riservata usata correttamente
	int valore = 42;
	Console.WriteLine(valore);
	
	// -------------------------
	// 🔽 Spiegazione riga per riga
	// -------------------------
	
	// 1. var numero = 5;
	//    → Creo una variabile chiamata "numero". Nessun problema: "numero" non è riservata.
	
	// 2. Console.WriteLine(numero);
	//    → Stampo il valore della variabile "numero".
	
	// 3. // var int = 10;
	//    → Commentato perché genera errore. "int" è una parola chiave del linguaggio.
	
	// 4. // var @int = 10;
	//    → Usare @ permette di "scappare" la parola, ma rende il codice poco leggibile.
	
	// 5. int valore = 42;
	//    → Uso corretto della parola chiave "int" per dichiarare una variabile intera.
	
	// 6. Console.WriteLine(valore);
	//    → Stampo il valore della variabile "valore".
	
}

