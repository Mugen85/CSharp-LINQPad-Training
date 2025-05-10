<Query Kind="Program" />

void Main()
{	
	// Questo è un commento singolo. Viene ignorato dal programma.
	
	Console.WriteLine("Questa riga verrà eseguita.");
	
	/*
	   Questo è un commento multiplo.
	   Può estendersi su più righe.
	   Utile per bloccare sezioni intere di codice o scrivere spiegazioni lunghe.
	*/
	
	Console.WriteLine("Anche questa riga viene eseguita.");
	
	// Console.WriteLine("Questa riga è commentata e non verrà eseguita.");
	
	/*
	Console.WriteLine("Questa riga è dentro un commento multiplo.");
	Console.WriteLine("Anche questa non verrà eseguita.");
	*/
	
	// -------------------------
	// 🔽 Spiegazione riga per riga
	// -------------------------
	
	// 1. // Questo è un commento singolo.
	//    → Il compilatore lo ignora completamente. Serve solo a spiegare qualcosa.
	
	// 2. Console.WriteLine("Questa riga verrà eseguita.");
	//    → Stampa un messaggio a video. È una riga attiva.
	
	// 3. /* ... */
	//    → Tutto il contenuto tra i simboli viene ignorato, anche su più righe.
	
	// 4. Console.WriteLine("Anche questa riga viene eseguita.");
	//    → Altra riga attiva. Il programma la eseguirà normalmente.
	
	// 5. // Console.WriteLine(...);
	//    → Riga commentata. Non verrà eseguita.
	
	// 6. /* Console.WriteLine(...) */
	//    → Più righe commentate. Comodo per "spegnere" temporaneamente del codice.
	
}

