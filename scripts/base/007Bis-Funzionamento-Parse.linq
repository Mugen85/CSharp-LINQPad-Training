<Query Kind="Program" />

void Main()
{
	// Mostro un messaggio all’utente per inserire un numero
	Console.WriteLine("Scrivi un numero con la virgola (es. 7.5):");
	
	// Leggo l’input dalla tastiera (sempre una stringa)
	string input = Console.ReadLine();
	
	// Converto la stringa in numero double usando Parse
	double numeroConvertito = double.Parse(input);
	
	// Stampo il risultato della conversione
	Console.WriteLine($"Hai scritto il numero: {numeroConvertito}");
	
	// Faccio una semplice operazione per dimostrare che ora è un numero vero
	Console.WriteLine($"Il doppio del numero è: {numeroConvertito * 2}");
	
}

