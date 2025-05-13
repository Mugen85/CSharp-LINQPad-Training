# 007 – Calcolo media numeri con Parse  
🔽 English version included below this section

---

## ✅ Obiettivo

Utilizzare l’input da tastiera per raccogliere tre numeri, convertirli in interi usando `int.Parse()`  
e calcolare la media aritmetica.

---

## 💡 Concetti

- `Console.ReadLine()` → legge input da tastiera (come stringa)  
- `int.Parse()` → converte una stringa in un numero intero  
- variabili intere → memorizzano valori numerici  
- operazioni aritmetiche → somma e divisione  
- `Console.WriteLine()` → stampa il risultato

---

## 🧠 Focus tecnico

- Comprendere il flusso: **input → parse → calcolo → output**  
- Attenzione agli spazi e ai formati dell’input  
- Importanza del tipo `int` per operazioni numeriche  
- Prevenire divisioni errate (se interi)  
- Utilizzo ordinato di variabili temporanee  
- ⚠️ In questo esempio **non è previsto il controllo dell’input**:  
  ➕ sarà introdotto più avanti, per gestire inserimenti errati in modo sicuro e professionale.

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("Inserisci il primo numero:");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci il secondo numero:");
    int numero2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci il terzo numero:");
    int numero3 = int.Parse(Console.ReadLine());

    int somma = numero1 + numero2 + numero3;
    double media = somma / 3.0;

    Console.WriteLine($"La media è: {media}");
}
```
---

# 007 – Calculate Average with Parse (English version)

---

## ✅ Objective

Use keyboard input to collect three numbers, convert them into integers using `int.Parse()`,  
and calculate their arithmetic average.

---

## 💡 Concepts

- `Console.ReadLine()` → reads input from keyboard (as a string)  
- `int.Parse()` → converts a string into an integer  
- integer variables → store numeric values  
- arithmetic operations → sum and division  
- `Console.WriteLine()` → prints the result

---

## 🧠 Technical focus

- Understand the flow: **input → parse → calculation → output**  
- Be careful with input format and spacing  
- Importance of using `int` for numeric operations  
- Avoid incorrect division (integer vs. decimal)  
- Use temporary variables to keep code clean  
- ⚠️ In this example, **input validation is not included**:  
  ➕ it will be added later to handle invalid input safely and professionally.

---

## 📄 Code

```csharp
void Main()
{
    Console.WriteLine("Enter the first number:");
    int number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second number:");
    int number2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the third number:");
    int number3 = int.Parse(Console.ReadLine());

    int sum = number1 + number2 + number3;
    double average = sum / 3.0;

    Console.WriteLine($"The average is: {average}");
}
