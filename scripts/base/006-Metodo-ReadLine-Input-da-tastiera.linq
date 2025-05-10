<Query Kind="Program" />

void Main()
{	
	// Mostro un messaggio per chiedere il nome all'utente
	Console.Write("Come ti chiami? ");
	
	// Leggo il nome inserito da tastiera
	string nome = Console.ReadLine();
	
	//Metodo più vecchio, ma utilizzabile
	//Console.WriteLine("Piacere di conoscerti, " + nome + "!");
	
	// Saluto usando l'interpolazione di stringa
	Console.WriteLine($"Piacere di conoscerti, {nome}!");	
	
}

