# 007Bis – Funzionamento di Parse  
🔽 English version included below this section
---

## ✅ Obiettivo

Comprendere come convertire un input testuale in un tipo numerico usando il metodo `Parse()` delle classi di tipo.

---

## 💡 Concetti

- `Console.ReadLine()` restituisce sempre una **stringa**  
- `int.Parse(stringa)` converte una stringa in un numero intero  
- `double.Parse(stringa)` converte in numero decimale  
- se la stringa non rappresenta un numero valido → errore in esecuzione  
- è importante validare o gestire eccezioni in input reali

---

## 🧠 Focus tecnico

- Differenza tra stringa e tipi numerici (`int`, `double`, ecc.)  
- Uso del metodo statico `Parse()`  
- Come eseguire il **cast implicito da string a numero**  
- Introduzione alla gestione degli errori di parsing (concetto da approfondire in seguito)

---

## 📄 Codice

```csharp
void Main()
{
    // Chiedo un numero all’utente
    Console.Write("Inserisci un numero: ");

    // Leggo l’input come stringa
    string input = Console.ReadLine();

    // Converto la stringa in intero
    int numero = int.Parse(input);

    // Uso il numero in un’operazione
    int raddoppio = numero * 2;

    Console.WriteLine($"Il doppio del numero è: {raddoppio}");
}
```
# 007Bis – How Parse Works  
🔼 Italian version above

---

## ✅ Goal

Understand how to convert a text input into a numeric type using the `Parse()` method of type classes.

---

## 💡 Concepts

- `Console.ReadLine()` always returns a **string**  
- `int.Parse(string)` converts a string to an integer  
- `double.Parse(string)` converts to a decimal number  
- if the string is not a valid number → runtime error  
- it’s important to validate or handle exceptions in real-world input

---

## 🧠 Technical focus

- Difference between strings and numeric types (`int`, `double`, etc.)  
- Use of the static method `Parse()`  
- How to perform **implicit casting from string to number**  
- Introduction to error handling during parsing (to be explored later)

---

## 📄 Code

```csharp
void Main()
{
    // Ask the user for a number
    Console.Write("Enter a number: ");

    // Read the input as a string
    string input = Console.ReadLine();

    // Convert the string to an integer
    int number = int.Parse(input);

    // Use the number in an operation
    int doubled = number * 2;

    Console.WriteLine($"The double of the number is: {doubled}");
}

