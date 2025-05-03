# 002 – Dichiarazione e inizializzazione variabili  
🔽 English version included below this section

---

## ✅ Obiettivo

Imparare a dichiarare e inizializzare variabili in C#, utilizzando la sintassi corretta e comprendendo il concetto di tipo di dato.

---

## 💡 Concetti

- dichiarare una variabile significa **creare uno spazio in memoria**  
- inizializzare significa **assegnare un valore iniziale** alla variabile  
- `string` → tipo per gestire testi  
- `int` → tipo per gestire numeri interi  
- `var` → permette l’inferenza del tipo da parte del compilatore  

---

## 🧠 Focus tecnico

- Differenza tra **dichiarazione** e **inizializzazione**  
- Uso di `var` rispetto a tipi espliciti (`int`, `string`, ecc.)  
- Sintassi corretta per le istruzioni  
- Come memorizzare dati in memoria per l’uso futuro nel programma  

---

## 📄 Codice

```csharp
void Main()
{
    // Dichiarazione ed inizializzazione esplicita
    string nome = "Mario";
    int eta = 30;

    // Dichiarazione ed inizializzazione implicita (type inference)
    var città = "Roma";
    var altezza = 1.75;

    Console.WriteLine($"Nome: {nome}, Età: {eta}");
    Console.WriteLine($"Città: {città}, Altezza: {altezza}");
}
```
# 002 – Variable declaration and initialization  
🔼 Italian version above

---

## ✅ Goal

Learn how to declare and initialize variables in C#, using the correct syntax and understanding the concept of data types.

---

## 💡 Concepts

- declaring a variable means **creating a space in memory**  
- initializing means **assigning an initial value** to the variable  
- `string` → type for handling text  
- `int` → type for handling integer numbers  
- `var` → allows the compiler to infer the type automatically  

---

## 🧠 Technical focus

- Difference between **declaration** and **initialization**  
- Using `var` versus explicit types (`int`, `string`, etc.)  
- Correct syntax for writing instructions  
- How to store data in memory for future use in the program  

---

## 📄 Code

```csharp
void Main()
{
    // Explicit declaration and initialization
    string name = "Mario";
    int age = 30;

    // Implicit declaration and initialization (type inference)
    var city = "Rome";
    var height = 1.75;

    Console.WriteLine($"Name: {name}, Age: {age}");
    Console.WriteLine($"City: {city}, Height: {height}");
}
