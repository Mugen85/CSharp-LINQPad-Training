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
```

# 000 – OOP: class, object and method  
🔼 Italian version above

---

## ✅ Goal

Understand the relationship between class and object through a concrete example:  
creating a real object from a class, assigning a property, and calling a method.

---

## 💡 Concepts

- `class` → defines a custom type
- `new` → creates an actual instance of that class
- public property (`Modello`) → stores data related to the object
- public method (`AvviaMotore`) → performs an action
- dot operator (`.`) → accesses object members (properties and methods)

---

## 🧠 Technical focus

- Understand the **difference between class and object**
- Use the **implicit constructor** to create an instance
- Assign a value to a public property
- Call a method via the object
- Learn the purpose of the **dot operator (`.`)**

---

## 📄 Code

```csharp
void Main()
{
	// Creating a real object (instance) from the Auto class
	var myCar = new Auto();
	
	// Assign a value to the "Modello" property of the object
	myCar.Modello = "Fiat Panda";
	
	// Call the "AvviaMotore" method of the object using the dot operator
	myCar.AvviaMotore();
}

// Definition of the Auto class
class Auto
{
	// Property: a string that represents the car model
	public string Modello;

	// Method: prints a message using the property
	public void AvviaMotore()
	{
		Console.WriteLine($"The car {Modello} has started the engine.");
	}
}

