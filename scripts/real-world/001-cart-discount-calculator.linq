<Query Kind="Program" />

// SNIPPET 001 - Cart Discount Calculator (real-world) - versione refactorizzata

// ✅ Clean Code Principles applicati:
// - SRP: ogni classe ha una responsabilità
// - OCP: sistema estensibile con interfacce per sconti
// - Funzioni brevi, nomi chiari, nessun if sparso

void Main()
{
	var prodotti = new List<Prodotto>
	{
		new Prodotto("Libro Clean Code", 35.99m, 2),
		new Prodotto("Mouse Logitech", 24.50m, 1),
		new Prodotto("Tazza C#", 12.00m, 1)
	};

	var sconti = new List<ISconto>
	{
		new ScontoQuantità(),
		new ScontoCodice("SUMMER10")
	};

	var calcolatore = new CalcolatoreCarrello(prodotti, sconti);
	var totale = calcolatore.TotaleFinale();

	VisualizzatoreCarrello.Stampa(prodotti, totale);
}
// 001: Modello per un prodotto del carrello
public class Prodotto
{
    public string Nome { get; }
    public decimal PrezzoUnitario { get; }
    public int Quantità { get; }

    public Prodotto(string nome, decimal prezzoUnitario, int quantità)
    {
        Nome = nome;
        PrezzoUnitario = prezzoUnitario;
        Quantità = quantità;
    }

    public decimal Totale => PrezzoUnitario * Quantità;
}

// 002: Interfaccia per strategie di sconto
public interface ISconto
{
    decimal Applica(decimal totale);
}

// 003: Nessuno sconto (default)
public class NessunoSconto : ISconto
{
    public decimal Applica(decimal totale) => totale;
}

// 004: Sconto fisso sopra i 100€
public class ScontoQuantità : ISconto
{
    public decimal Applica(decimal totale) => totale >= 100 ? totale * 0.9m : totale;
}

// 005: Sconto codice "SUMMER10"
public class ScontoCodice : ISconto
{
    private readonly string _codice;

    public ScontoCodice(string codice)
    {
        _codice = codice;
    }

    public decimal Applica(decimal totale) => _codice == "SUMMER10" ? totale * 0.9m : totale;
}

// 006: Servizio di calcolo carrello
public class CalcolatoreCarrello
{
    private readonly List<Prodotto> _prodotti;
    private readonly List<ISconto> _sconti;

    public CalcolatoreCarrello(List<Prodotto> prodotti, List<ISconto> sconti)
    {
        _prodotti = prodotti;
        _sconti = sconti;
    }

    public decimal TotaleFinale()
    {
        decimal totale = _prodotti.Sum(p => p.Totale);
        foreach (var sconto in _sconti)
        {
            totale = sconto.Applica(totale);
        }
        return totale;
    }

    public List<Prodotto> GetProdotti() => _prodotti;
}

// 007: Servizio separato per stampa (SRP)
public static class VisualizzatoreCarrello
{
	public static void Stampa(List<Prodotto> prodotti, decimal totale)
	{
		Console.WriteLine("🛒 Carrello:");
		foreach (var p in prodotti)
		{
			Console.WriteLine($"- {p.Nome}: {p.Quantità} x {p.PrezzoUnitario:C} = {p.Totale:C}");
		}
		Console.WriteLine($"Totale con sconti applicati: {totale:C}");
	}
}


