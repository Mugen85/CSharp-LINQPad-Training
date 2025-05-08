# 017 – `const`: dichiarare valori immutabili  
🔽 English version included below this section

---

## ✅ Obiettivo

Capire l’uso della parola chiave `const` per dichiarare **valori immutabili** in C#.  
Mostrare quando e perché usarla al posto di una variabile normale.

---

## 💡 Concetti

- `const` → definisce una **costante**, cioè un valore **fisso e immutabile**  
- il valore **deve essere assegnato al momento della dichiarazione**  
- una costante **non può mai cambiare** durante l’esecuzione del programma  
- utile per codificare valori simbolici o significativi (es. `PI`, `etaMinima`, `IVA`)

---

## 🧠 Focus tecnico

- Differenza tra `const` e `var`/variabili normali  
- Scrivere codice più leggibile e sicuro  
- Rendere esplicito che un valore **non va modificato**  
- Riconoscere quando è utile una costante per chiarezza e manutenzione  
- ⚠️ Le costanti vengono sostituite dal compilatore nei punti d’uso

---

## 📄 Codice

```csharp
void Main()
{
    const int etaMinima = 18;

    Console.WriteLine($"Per entrare devi avere almeno {etaMinima} anni.");

    // etaMinima = 21; // ❌ Errore: una costante non può essere modificata
}
```
---

# 017 – `const`: declaring immutable values (English version)

---

## ✅ Objective

Understand how to use the `const` keyword to declare **immutable values** in C#.  
Learn when and why to use it instead of a regular variable.

---

## 💡 Concepts

- `const` → defines a **constant**, a value that is **fixed and unchangeable**  
- the value **must be assigned at declaration time**  
- a constant **cannot be modified** during program execution  
- useful for defining symbolic or meaningful values (e.g. `PI`, `minimumAge`, `VAT`)

---

## 🧠 Technical focus

- Difference between `const` and `var`/regular variables  
- Write safer and more readable code  
- Clearly express that a value **must not change**  
- Know when a constant helps maintainability and clarity  
- ⚠️ Constants are replaced at compile time in all usage points

---

## 📄 Code

```csharp
void Main()
{
    const int minimumAge = 18;

    Console.WriteLine($"You must be at least {minimumAge} years old to enter.");

    // minimumAge = 21; // ❌ Error: a constant cannot be modified
}
