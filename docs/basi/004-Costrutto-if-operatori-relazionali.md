# 004 – Costrutto if e operatori relazionali  
🔽 English version included below this section

---

## ✅ Obiettivo

Capire come usare il costrutto `if` per eseguire controlli logici e prendere decisioni nel codice.  
Utilizzare operatori relazionali per confrontare valori numerici.

---

## 💡 Concetti

- `if (condizione)` → esegue un blocco di codice solo se la condizione è vera  
- `else` → blocco alternativo se la condizione è falsa  
- `==` → uguale  
- `!=` → diverso  
- `>`  → maggiore  
- `<`  → minore  
- `>=` → maggiore o uguale  
- `<=` → minore o uguale  

---

## 🧠 Focus tecnico

- Comprendere come valutare condizioni booleane  
- Scrivere correttamente una struttura `if/else`  
- Usare gli operatori relazionali per confrontare due valori  
- Leggere il flusso di esecuzione in base al risultato del confronto  

---

## 📄 Codice

```csharp
void Main()
{
    int numero = 5;

    if (numero > 0)
    {
        Console.WriteLine("Il numero è positivo");
    }
    else if (numero < 0)
    {
        Console.WriteLine("Il numero è negativo");
    }
    else
    {
        Console.WriteLine("Il numero è zero");
    }
}
```
# 004 – If statement and relational operators  
🔼 Italian version above

---

## ✅ Goal

Understand how to use the `if` statement to perform logical checks and make decisions in code.  
Use relational operators to compare numeric values.

---

## 💡 Concepts

- `if (condition)` → executes a block of code only if the condition is true  
- `else` → alternative block if the condition is false  
- `==` → equal  
- `!=` → not equal  
- `>`  → greater than  
- `<`  → less than  
- `>=` → greater than or equal to  
- `<=` → less than or equal to  

---

## 🧠 Technical focus

- Understand how to evaluate boolean conditions  
- Write a correct `if/else` structure  
- Use relational operators to compare two values  
- Follow the flow of execution based on the comparison result  

---

## 📄 Code

```csharp
void Main()
{
    int number = 5;

    if (number > 0)
    {
        Console.WriteLine("The number is positive");
    }
    else if (number < 0)
    {
        Console.WriteLine("The number is negative");
    }
    else
    {
        Console.WriteLine("The number is zero");
    }
}
