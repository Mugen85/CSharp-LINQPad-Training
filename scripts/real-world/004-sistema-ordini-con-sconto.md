# snippet-004-sistema-ordini-con-sconto.md

## 🎯 Obiettivo
Simulare un sistema di gestione ordini per un piccolo magazzino, con:
- Definizione di classi `Prodotto` e `Ordine`
- Calcolo del totale con possibile sconto
- Gestione di errori tramite blocco `try-catch`

## 🧠 Concetti utilizzati
- Classi e proprietà
- Costruttori
- Liste generiche
- Metodi per logica di business
- Condizioni `if`
- Cicli `foreach`
- Gestione delle eccezioni con `try-catch`
- Formattazione monetaria
- Separazione delle responsabilità tra classi

## 🔍 Spiegazione riga per riga

### `Prodotto`
- `Nome`, `Prezzo` e `Quantità` sono proprietà automatiche.
- Il costruttore valida che la quantità non sia negativa, altrimenti genera un'eccezione.
- Il metodo `CalcolaTotale` restituisce il valore del prodotto (prezzo × quantità).

### `Ordine`
- Contiene una lista di prodotti (`List<Prodotto>`).
- Il metodo `AggiungiProdotto` aggiunge un prodotto alla lista.
- Il metodo `CalcolaTotaleOrdine` somma tutti i totali parziali e applica uno sconto del 10% se il totale supera 100.
- Il metodo `StampaRiepilogo` stampa ogni riga dell’ordine e il totale finale.

### `Main()`
- Crea alcuni oggetti `Prodotto`.
- Li aggiunge a un oggetto `Ordine`.
- Stampa il riepilogo.
- Tutto il blocco è contenuto in un `try-catch`, che cattura eventuali errori e li stampa.

```csharp
// 001: Classe Prodotto
public class Prodotto
{
    public string Nome { get; set; } // 002: Proprietà Nome
    public decimal Prezzo { get; set; } // 003: Proprietà Prezzo
    public int Quantità { get; set; } // 004: Proprietà Quantità

    // 005: Costruttore
    public Prodotto(string nome, decimal prezzo, int quantità)
    {
        if (quantità < 0)
            throw new ArgumentException("La quantità non può essere negativa.");

        Nome = nome;
        Prezzo = prezzo;
        Quantità = quantità;
    }

    // 006: Metodo per calcolare il totale per il prodotto
    public decimal CalcolaTotale()
    {
        return Prezzo * Quantità;
    }
}

// 007: Classe Ordine
public class Ordine
{
    private List<Prodotto> prodotti = new List<Prodotto>(); // 008: Lista di prodotti

    // 009: Metodo per aggiungere un prodotto all'ordine
    public void AggiungiProdotto(Prodotto prodotto)
    {
        prodotti.Add(prodotto);
    }

    // 010: Metodo per calcolare il totale dell'ordine
    public decimal CalcolaTotaleOrdine()
    {
        decimal totale = 0;
        foreach (var prodotto in prodotti)
        {
            totale += prodotto.CalcolaTotale(); // 011: Uso del metodo CalcolaTotale
        }

        // 012: Applicazione di uno sconto se il totale supera 100
        if (totale > 100)
        {
            totale *= 0.9m; // 10% di sconto
        }

        return totale;
    }

    // 013: Metodo per stampare il riepilogo dell'ordine
    public void StampaRiepilogo()
    {
        Console.WriteLine("Riepilogo Ordine:");
        foreach (var prodotto in prodotti)
        {
            Console.WriteLine($"- {prodotto.Nome}: {prodotto.Quantità} x {prodotto.Prezzo:C} = {prodotto.CalcolaTotale():C}");
        }
        Console.WriteLine($"Totale Ordine: {CalcolaTotaleOrdine():C}");
    }
}

// 014: Punto di ingresso del programma per LINQPad
void Main()
{
    try
    {
        Ordine ordine = new Ordine();

        // 015: Creazione di prodotti
        Prodotto prodotto1 = new Prodotto("Mouse", 25.50m, 2);
        Prodotto prodotto2 = new Prodotto("Tastiera", 45.00m, 1);
        Prodotto prodotto3 = new Prodotto("Monitor", 150.00m, 1);

        // 016: Aggiunta dei prodotti all'ordine
        ordine.AggiungiProdotto(prodotto1);
        ordine.AggiungiProdotto(prodotto2);
        ordine.AggiungiProdotto(prodotto3);

        // 017: Stampa del riepilogo dell'ordine
        ordine.StampaRiepilogo();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Errore: {ex.Message}"); // 018: Gestione delle eccezioni
    }
}
```

---

# snippet-004-order-system-with-discount.md

## 🎯 Objective
Simulate a basic order management system for a small inventory, featuring:
- Definition of `Product` and `Order` classes
- Total calculation with possible discount
- Error handling with a `try-catch` block

## 🧠 Concepts used
- Classes and properties
- Constructors
- Generic lists
- Business logic methods
- `if` conditions
- `foreach` loops
- Exception handling with `try-catch`
- Currency formatting
- Class responsibility separation

## 🔍 Line-by-line explanation

### `Product`
- `Name`, `Price`, and `Quantity` are auto-properties.
- The constructor checks that quantity is not negative, or throws an exception.
- The method `CalculateTotal` returns the total value for a product (price × quantity).

### `Order`
- Contains a list of products (`List<Prodotto>`).
- The `AddProduct` method appends a product to the list.
- The `CalculateOrderTotal` method sums all partial totals and applies a 10% discount if the total exceeds 100.
- The `PrintSummary` method outputs each product line and the final total.

### `Main()`
- Creates several `Product` objects.
- Adds them to an `Order` object.
- Prints the summary.
- The whole logic is wrapped in a `try-catch` block that catches and prints any exceptions.

```csharp
// 001: Product class
public class Product
{
    public string Name { get; set; } // 002: Property Name
    public decimal Price { get; set; } // 003: Property Price
    public int Quantity { get; set; } // 004: Property Quantity

    // 005: Constructor
    public Product(string name, decimal price, int quantity)
    {
        if (quantity < 0)
            throw new ArgumentException("Quantity cannot be negative.");

        Name = name;
        Price = price;
        Quantity = quantity;
    }

    // 006: Method to calculate total value
    public decimal CalculateTotal()
    {
        return Price * Quantity;
    }
}

// 007: Order class
public class Order
{
    private List<Product> products = new List<Product>(); // 008: List of products

    // 009: Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // 010: Method to calculate the total order value
    public decimal CalculateOrderTotal()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.CalculateTotal(); // 011: Use of CalculateTotal method
        }

        // 012: Apply discount if total exceeds 100
        if (total > 100)
        {
            total *= 0.9m; // 10% discount
        }

        return total;
    }

    // 013: Method to print order summary
    public void PrintSummary()
    {
        Console.WriteLine("Order Summary:");
        foreach (var product in products)
        {
            Console.WriteLine($"- {product.Name}: {product.Quantity} x {product.Price:C} = {product.CalculateTotal():C}");
        }
        Console.WriteLine($"Total Order Value: {CalculateOrderTotal():C}");
    }
}

// 014: Main entry point for LINQPad
void Main()
{
    try
    {
        Order order = new Order();

        // 015: Create products
        Product product1 = new Product("Mouse", 25.50m, 2);
        Product product2 = new Product("Keyboard", 45.00m, 1);
        Product product3 = new Product("Monitor", 150.00m, 1);

        // 016: Add products to the order
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);

        // 017: Print the order summary
        order.PrintSummary();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}"); // 018: Exception handling
    }
}
```


