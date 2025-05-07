<Query Kind="Program" />

void Main()
{
	// Chiedo all’utente di inserire un numero
	Console.WriteLine("Inserisci un numero per calcolare la sua tabellina:");
	
	// Leggo il numero come stringa
	string inputNumero = Console.ReadLine();
	
	// Converto l’input da stringa a intero
	int numero = int.Parse(inputNumero);
	
	// Mostro un’intestazione prima della tabellina
	Console.WriteLine($"Ecco la tabellina del {numero}:");
	
	// Uso un ciclo for per stampare i risultati da 1 a 10
	for (int i = 1; i <= 10; i++);
	
	/*
	🧠 Nota didattica:
	Questo esercizio è perfetto per consolidare il ciclo for in combinazione con l’input utente.
	Aiuta anche a familiarizzare con la moltiplicazione automatica e la ripetizione controllata.
	*/	
}

