# 000 – OOP: classe, oggetto e metodo

🔽 English version below

---

## ✅ Obiettivo

Comprendere i concetti fondamentali della programmazione orientata agli oggetti (OOP) in C#:  
- cos’è una classe  
- cos’è un oggetto  
- come si usano le proprietà e i metodi tramite l’operatore punto (`.`)

---

## 💡 Concetti

- `class` → definisce un modello di oggetto
- `new` → crea un’istanza reale della classe
- `proprietà` → variabili pubbliche appartenenti all’oggetto
- `metodi` → azioni che l’oggetto può eseguire
- `.` → serve per accedere a proprietà e metodi

---

## 🧠 Focus tecnico

- Dichiarazione e istanziazione di una classe (`Auto`)
- Assegnazione valori a una proprietà pubblica (`Modello`)
- Chiamata a un metodo pubblico (`AvviaMotore`)
- Uso dell’operatore punto (`.`) per accedere a membri dell’oggetto
- Concetto di incapsulamento (a livello introduttivo)

---

## 📄 Codice

```csharp
void Main()
{
    // Creazione di un oggetto reale (istanza) a partire dalla classe Auto
    var miaAuto = new Auto();
    
    // Assegno un valore alla proprietà "Modello" dell'oggetto
    miaAuto.Modello = "Fiat Panda";
    
    // Chiamo il metodo "AvviaMotore" dell'oggetto usando il punto
    miaAuto.AvviaMotore();
}

// Definizione della classe Auto
class Auto
{
    // Proprietà: una stringa che rappresenta il modello dell'auto
    public string Modello;

    // Metodo: stampa una frase usando la proprietà
    public void AvviaMotore()
    {
        Console.WriteLine($"L'auto {Modello} ha avviato il motore.");
    }
}
