<Query Kind="Program" />

void Main()
{
	// Dichiarazione esplicita: sto dicendo chiaramente che è un intero
	int numeroEsplicito = 10;
	
	// Dichiarazione implicita con var: il compilatore capisce che è int
	var numero = 10;
	
	// Anche qui, il compilatore deduce che è string perché il valore è un testo
	var nome = "Mario";
	
	// Per tipi più lunghi o complessi, var rende il codice più leggibile
	var dataCorrente = DateTime.Now;
	
	// Non puoi fare questo: var richiede un valore per capire il tipo
	// var valoreNonInizializzato; ❌ ERRORE
	
	// Mostro tutti i valori stampati per verifica
	Console.WriteLine($"numeroEsplicito (int): {numeroEsplicito}");
	Console.WriteLine($"numero (var int): {numero}");
	Console.WriteLine($"nome (var string): {nome}");
	Console.WriteLine($"dataCorrente (var DateTime): {dataCorrente}");
	
	/*
	🔎 Quando è consigliato usare var?
	
	✅ Quando il tipo è ovvio (es: var numero = 5;)
	
	✅ Quando il tipo è molto lungo o complesso (es: Dictionary<string, List<int>>)
	
	❌ Quando il tipo non è chiaro a colpo d’occhio → è meglio scriverlo esplicitamente
	*/
}

