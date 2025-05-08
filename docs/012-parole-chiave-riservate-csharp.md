# 012 – Parole chiave riservate in C#  
🔽 English version included below this section

---

## ✅ Obiettivo

Comprendere cosa sono le **parole chiave riservate** in C#  
e perché non possono essere usate come nomi di variabili, metodi o classi.  
Mostrare come il compilatore reagisce e come si può aggirare il problema in casi particolari.

---

## 💡 Concetti

- parole chiave → termini riservati dal linguaggio per funzioni specifiche  
- non possono essere usate come identificatori (`class`, `int`, `for`, `namespace`, ecc.)  
- causano errore in compilazione se usate come variabili  
- `@` (chiocciola) → permette in casi eccezionali di usare una parola chiave come nome (es. `@class`)  
- buona pratica → evitare sempre l’uso di parole chiave come nomi personalizzati

---

## 🧠 Focus tecnico

- Capire la differenza tra parole **riservate** e parole **libere**  
- Riconoscere un errore del compilatore legato a identificatori non validi  
- Conoscere il significato di `@` davanti a un nome inusuale  
- Riflettere sul naming chiaro e leggibile in un progetto professionale  
- ⚠️ Usare `@` è consentito, ma **sconsigliato in produzione**

---

## 📄 Codice

```csharp
void Main()
{
    // int class = 5; ❌ Errore: "class" è una parola riservata

    int @class = 5; // ✅ Valido ma da evitare
    Console.WriteLine(@class);
}
```
---

# 012 – Reserved keywords in C# (English version)

---

## ✅ Objective

Understand what **reserved keywords** are in C#,  
why they cannot be used as names for variables, methods, or classes,  
and how to work around the issue in very specific cases.

---

## 💡 Concepts

- keywords → terms reserved by the language for specific purposes  
- they cannot be used as identifiers (`class`, `int`, `for`, `namespace`, etc.)  
- using them as variable names causes a compilation error  
- `@` (at symbol) → allows bypassing the rule (e.g. `@class`)  
- best practice → always avoid using reserved keywords as variable or method names

---

## 🧠 Technical focus

- Know the difference between **reserved** and **custom** names  
- Recognize compiler errors related to invalid identifiers  
- Understand the purpose of `@` when used before a name  
- Emphasize clean, clear naming in a professional codebase  
- ⚠️ While `@` is allowed, it is **not recommended** in real-world code

---

## 📄 Code

```csharp
void Main()
{
    // int class = 5; ❌ Error: "class" is a reserved keyword

    int @class = 5; // ✅ Valid, but not recommended
    Console.WriteLine(@class);
}
