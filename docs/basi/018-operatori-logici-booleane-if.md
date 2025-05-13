# 018 – Operatori logici e booleani in un `if`  
🔽 English version included below this section

---

## ✅ Obiettivo

Capire come utilizzare **operatori logici (`&&`, `||`)** e **valori booleani** all’interno di una condizione `if`.  
Mostrare come combinare più condizioni e rendere il codice più espressivo e flessibile.

---

## 💡 Concetti

- `bool` → tipo booleano (valori: `true`, `false`)  
- `&&` → operatore logico **AND** (tutte le condizioni devono essere vere)  
- `||` → operatore logico **OR** (basta che una condizione sia vera)  
- `!` → negazione logica (**NOT**)  
- `if (condizione)` → esegue un blocco solo se la condizione è `true`

---

## 🧠 Focus tecnico

- Usare più condizioni nello stesso `if`  
- Riconoscere la **precedenza logica** degli operatori (`&&` ha priorità su `||`)  
- Valutare espressioni booleane complesse  
- Leggere correttamente un’espressione condizionale  
- ⚠️ Attenzione alle condizioni complesse: meglio semplificarle per leggibilità

---

## 📄 Codice

```csharp
void Main()
{
    bool isAdmin = true;
    bool isPremium = false;
    int eta = 25;

    if ((isAdmin || isPremium) && eta >= 18)
    {
        Console.WriteLine("Accesso consentito.");
    }
    else
    {
        Console.WriteLine("Accesso negato.");
    }
}
```
---

# 018 – Logical and boolean operators in an `if` (English version)

---

## ✅ Objective

Learn how to use **logical operators (`&&`, `||`)** and **boolean values** inside an `if` condition.  
Show how to combine multiple conditions to make code more expressive and flexible.

---

## 💡 Concepts

- `bool` → boolean type (`true`, `false`)  
- `&&` → logical **AND** operator (all conditions must be true)  
- `||` → logical **OR** operator (at least one condition must be true)  
- `!` → logical negation (**NOT**)  
- `if (condition)` → executes a block only if the condition is `true`

---

## 🧠 Technical focus

- Combine multiple conditions in the same `if`  
- Understand **logical operator precedence** (`&&` has higher priority than `||`)  
- Evaluate complex boolean expressions  
- Correctly read conditional expressions  
- ⚠️ Be cautious with overly complex conditions: prefer readability

---

## 📄 Code

```csharp
void Main()
{
    bool isAdmin = true;
    bool isPremium = false;
    int age = 25;

    if ((isAdmin || isPremium) && age >= 18)
    {
        Console.WriteLine("Access granted.");
    }
    else
    {
        Console.WriteLine("Access denied.");
    }
}

