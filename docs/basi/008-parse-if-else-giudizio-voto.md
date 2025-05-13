# 008 – Parse, if/else e giudizio sul voto  
🔽 English version included below this section

---

## ✅ Obiettivo

Inserire un numero da tastiera, convertirlo in intero con `int.Parse()`,  
valutare il voto con una struttura `if/else` e restituire un giudizio testuale.

---

## 💡 Concetti

- `Console.ReadLine()` → input da tastiera  
- `int.Parse()` → conversione da stringa a numero intero  
- `if/else` → struttura condizionale  
- operatori relazionali → `>=`, `<`, `==`  
- stampa del risultato con `Console.WriteLine()`

---

## 🧠 Focus tecnico

- Comprendere il **flusso input → parse → condizione → output**  
- Saper usare `if/else if/else` per coprire più casi  
- Usare **operatori relazionali** per confrontare valori  
- Associare un valore numerico ad un messaggio descrittivo  
- ⚠️ **Nessun controllo sull’input**: l’utente potrebbe inserire valori non numerici o non validi  
  ➕ Introdurremo in seguito un controllo robusto per gestire errori di input e garantire affidabilità

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("Inserisci il voto (da 0 a 10):");
    int voto = int.Parse(Console.ReadLine());

    if (voto >= 9)
    {
        Console.WriteLine("Giudizio: Ottimo");
    }
    else if (voto >= 7)
    {
        Console.WriteLine("Giudizio: Buono");
    }
    else if (voto >= 6)
    {
        Console.WriteLine("Giudizio: Sufficiente");
    }
    else
    {
        Console.WriteLine("Giudizio: Insufficiente");
    }
}
```
---

# 008 – Parse, if/else and grade evaluation (English version)

---

## ✅ Objective

Read a number from keyboard input, convert it to an integer using `int.Parse()`,  
evaluate the grade using an `if/else` structure, and return a text-based judgment.

---

## 💡 Concepts

- `Console.ReadLine()` → reads user input from the keyboard  
- `int.Parse()` → converts a string into an integer  
- `if/else` → conditional branching  
- relational operators → `>=`, `<`, `==`  
- prints the output with `Console.WriteLine()`

---

## 🧠 Technical focus

- Understand the **flow: input → parse → condition → output**  
- Use `if/else if/else` to handle multiple branches  
- Apply **relational operators** to compare values  
- Associate a numeric input with a descriptive message  
- ⚠️ **No input validation is implemented**: users may enter invalid or non-numeric values  
  ➕ We will later add robust input checks to make the program more reliable

---

## 📄 Code

```csharp
void Main()
{
    Console.WriteLine("Enter your grade (from 0 to 10):");
    int grade = int.Parse(Console.ReadLine());

    if (grade >= 9)
    {
        Console.WriteLine("Evaluation: Excellent");
    }
    else if (grade >= 7)
    {
        Console.WriteLine("Evaluation: Good");
    }
    else if (grade >= 6)
    {
        Console.WriteLine("Evaluation: Pass");
    }
    else
    {
        Console.WriteLine("Evaluation: Fail");
    }
}

