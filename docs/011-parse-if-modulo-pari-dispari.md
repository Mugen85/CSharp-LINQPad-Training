# 011 – Parse, if e modulo: pari o dispari  
🔽 English version included below this section

---

## ✅ Obiettivo

Permettere all’utente di inserire un numero intero da tastiera,  
verificare se è pari o dispari usando l’operatore modulo `%`  
e stampare il risultato con un messaggio testuale.

---

## 💡 Concetti

- `Console.ReadLine()` → input da tastiera  
- `int.Parse()` → conversione da stringa a intero  
- `if/else` → condizione logica  
- operatore `%` (modulo) → restituisce il resto di una divisione  
- numeri pari → il resto della divisione per 2 è 0  
- numeri dispari → il resto è diverso da 0

---

## 🧠 Focus tecnico

- Acquisizione e conversione dell’input utente  
- Uso del modulo per determinare la parità  
- Struttura condizionale semplice `if/else`  
- Buone pratiche di lettura dell’input prima dell’elaborazione  
- ⚠️ In questo esempio **non è ancora presente il controllo dell’input**  
  ➕ Verrà introdotto in futuro per gestire errori o input non numerici

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("Inserisci un numero:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("Il numero è pari.");
    }
    else
    {
        Console.WriteLine("Il numero è dispari.");
    }
}
```
---

# 011 – Parse, if and modulo: even or odd (English version)

---

## ✅ Objective

Allow the user to enter an integer from the keyboard,  
check if the number is even or odd using the modulo operator `%`,  
and print the result with a text message.

---

## 💡 Concepts

- `Console.ReadLine()` → reads input from the keyboard  
- `int.Parse()` → converts a string into an integer  
- `if/else` → conditional logic structure  
- `%` (modulo operator) → returns the remainder of a division  
- even numbers → division by 2 has no remainder  
- odd numbers → division by 2 has a remainder of 1

---

## 🧠 Technical focus

- Read and convert user input  
- Use modulo to determine evenness  
- Apply a basic `if/else` condition  
- Good practice: process input only after reading  
- ⚠️ In this example, **input validation is not yet implemented**  
  ➕ We will add proper input handling later to prevent errors with non-numeric values

---

## 📄 Code

```csharp
void Main()
{
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine("The number is even.");
    }
    else
    {
        Console.WriteLine("The number is odd.");
    }
}

