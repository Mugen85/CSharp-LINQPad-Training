<Query Kind="Program" />

void Main()
{
	int a = 10;
	int b = 3;
	
	// Somma
	Console.WriteLine("Somma: " + (a + b));
	
	// Sottrazione
	Console.WriteLine("Sottrazione: " + (a - b));
	
	// Moltiplicazione
	Console.WriteLine("Moltiplicazione: " + (a * b));
	
	// Divisione
	Console.WriteLine("Divisione: " + ((double)a / b)); // cast a double per avere virgola
	
	// Resto della divisione
	Console.WriteLine("Resto: " + (a % b));
	
}

