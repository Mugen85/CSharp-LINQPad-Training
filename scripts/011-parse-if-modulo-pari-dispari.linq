<Query Kind="Program" />

void Main()
{
	
	var messaggio = "Inserisci un numero intero:";
	Console.WriteLine(messaggio);
	
	var input = Console.ReadLine();
	var numero = int.Parse(input);
	
	if (numero % 2 == 0)
	{
		Console.WriteLine("Il numero è pari.");
	}
	else
	{
		Console.WriteLine("Il numero è dispari.");
	}
	
	// -------------------------
	// 🔽 Spiegazione riga per riga
	// -------------------------
	
	// 1. var messaggio = "Inserisci un numero intero:";
	//    → Salviamo il testo da mostrare all'utente
	
	// 2. Console.WriteLine(messaggio);
	//    → Stampiamo il messaggio per chiedere il numero
	
	// 3. var input = Console.ReadLine();
	//    → Leggiamo il numero digitato, ma in formato testo (stringa)
	
	// 4. var numero = int.Parse(input);
	//    → Convertiamo l’input in numero intero con Parse
	
	// 5. if (numero % 2 == 0)
	//    → Verifica se il numero è divisibile per 2 (pari)
	
	// 6. Console.WriteLine("Il numero è pari.");
	//    → Mostra il messaggio se la condizione è vera
	
	// 7. else
	//    → Alternativa se la condizione è falsa (cioè dispari)
	
	// 8. Console.WriteLine("Il numero è dispari.");
	//    → Mostra il messaggio per i numeri dispari
	
}

