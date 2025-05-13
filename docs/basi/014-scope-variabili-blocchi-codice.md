# 014 – Scope delle variabili e blocchi di codice  
🔽 English version included below this section

---

## ✅ Obiettivo

Comprendere cosa si intende per **scope (ambito)** di una variabile in C#  
e come questo è determinato dai **blocchi di codice delimitati da `{}`**.  
Dimostrare con un esempio cosa succede quando una variabile viene usata fuori dal suo scope.

---

## 💡 Concetti

- una variabile esiste solo **all’interno del blocco** in cui è stata dichiarata  
- un blocco è qualsiasi porzione di codice racchiusa tra `{` e `}`  
- fuori dallo scope → errore in compilazione (`variabile non esiste nel contesto attuale`)  
- è possibile dichiarare più variabili con lo stesso nome in blocchi separati  
- lo scope aiuta a mantenere il codice **pulito e senza conflitti**

---

## 🧠 Focus tecnico

- Capire dove una variabile può essere **letta o modificata**  
- Prevenire errori dovuti a **visibilità errata**  
- Evitare riutilizzi pericolosi di nomi di variabili  
- Comprendere che **le variabili non “sopravvivono” fuori dal proprio blocco**

---

## 📄 Codice

```csharp
void Main()
{
    if (true)
    {
        string messaggio = "Ciao dal blocco IF!";
        Console.WriteLine(messaggio);
    }

    // Console.WriteLine(messaggio); // ❌ Errore: messaggio non esiste qui
}
```
---

# 014 – Variable scope and code blocks (English version)

---

## ✅ Objective

Understand the concept of **scope** in C#:  
how a variable’s visibility is determined by the **code blocks** defined by `{}`.  
Demonstrate what happens when a variable is used outside of its scope.

---

## 💡 Concepts

- a variable exists only **within the block** where it is declared  
- a block is any section of code enclosed in `{` and `}`  
- accessing it outside the scope → compile-time error (`variable does not exist in the current context`)  
- variables with the same name can be declared in different blocks  
- proper scope helps keep code **clean and conflict-free**

---

## 🧠 Technical focus

- Understand where a variable can be **read or modified**  
- Prevent mistakes caused by incorrect **visibility assumptions**  
- Avoid accidental reuse of variable names  
- Know that variables do not “survive” outside their own block

---

## 📄 Code

```csharp
void Main()
{
    if (true)
    {
        string message = "Hello from inside the IF block!";
        Console.WriteLine(message);
    }

    // Console.WriteLine(message); // ❌ Error: message does not exist here
}

