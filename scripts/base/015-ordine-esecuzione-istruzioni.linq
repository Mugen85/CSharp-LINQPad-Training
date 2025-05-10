<Query Kind="Program" />

void Main()
{
	Console.WriteLine("1. Inizio del programma");
	
	var numero = 5;
	Console.WriteLine("2. Numero iniziale: " + numero);
	
	numero = numero + 3;
	Console.WriteLine("3. Dopo l’aggiunta: " + numero);
	
	if (numero > 5)
	{
		Console.WriteLine("4. Il numero è maggiore di 5");
	}
	
	Console.WriteLine("5. Fine del programma");
	
	// -------------------------
	// 🔽 Spiegazione riga per riga
	// -------------------------
	
	// 1. Console.WriteLine("1. Inizio del programma");
	//    → Prima riga eseguita. Stampa un messaggio iniziale.
	
	// 2. var numero = 5;
	//    → Dichiarazione e inizializzazione della variabile numero.
	
	// 3. Console.WriteLine("2. Numero iniziale: " + numero);
	//    → Stampa il valore corrente di numero, che è 5.
	
	// 4. numero = numero + 3;
	//    → Aggiungo 3 a numero. Ora vale 8.
	
	// 5. Console.WriteLine("3. Dopo l’aggiunta: " + numero);
	//    → Stampa il nuovo valore (8).
	
	// 6. if (numero > 5) { ... }
	//    → Controllo: 8 è maggiore di 5, quindi eseguo il blocco.
	
	// 7. Console.WriteLine("4. Il numero è maggiore di 5");
	//    → Viene eseguito perché la condizione è vera.
	
	// 8. Console.WriteLine("5. Fine del programma");
	//    → Eseguita sempre, perché è fuori dall’if. Chiude il flusso.
	
}

