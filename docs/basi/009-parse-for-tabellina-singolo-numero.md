# 009 – Parse + ciclo for: tabellina di un numero  
🔽 English version included below this section

---

## ✅ Obiettivo

Permettere all’utente di inserire un numero da tastiera, convertirlo in intero  
e calcolare la **tabellina di quel numero** da 1 a 10 utilizzando un ciclo `for`.

---

## 💡 Concetti

- `Console.ReadLine()` → input da tastiera  
- `int.Parse()` → converte la stringa in numero intero  
- `for` → ripetizione controllata da contatore  
- interpolazione `$""` → inserimento dinamico di variabili nelle stringhe  
- moltiplicazione `*` → operazione aritmetica

---

## 🧠 Focus tecnico

- Acquisire un numero da input  
- Usare `int.Parse()` per la conversione  
- Costruire un ciclo `for` che va da 1 a 10  
- Stampare il risultato ad ogni iterazione  
- Comprendere come una variabile può essere **parametro dinamico** di calcolo  
- ⚠️ Il programma **non include ancora il controllo sul tipo di input**  
  ➕ in futuro aggiungeremo il controllo per evitare crash in caso di valori non numerici

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("Inserisci un numero:");
    int numero = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        int risultato = numero * i;
        Console.WriteLine($"{numero} x {i} = {risultato}");
    }
}
```
---

# 009 – Parse + for loop: multiplication table (English version)

---

## ✅ Objective

Allow the user to input a number via keyboard, convert it to an integer,  
and calculate the **multiplication table** of that number from 1 to 10 using a `for` loop.

---

## 💡 Concepts

- `Console.ReadLine()` → reads input from keyboard  
- `int.Parse()` → converts a string to an integer  
- `for` → counter-based loop  
- string interpolation `$""` → injects variables into strings  
- multiplication `*` → arithmetic operator

---

## 🧠 Technical focus

- Acquire numeric input from the user  
- Use `int.Parse()` to convert string input  
- Build a `for` loop that counts from 1 to 10  
- Print the result of each multiplication step  
- Understand how a variable can be used as a **dynamic parameter**  
- ⚠️ This example **does not yet include input validation**  
  ➕ input checks will be added in the future to handle non-numeric values gracefully

---

## 📄 Code

```csharp
void Main()
{
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        int result = number * i;
        Console.WriteLine($"{number} x {i} = {result}");
    }
}

