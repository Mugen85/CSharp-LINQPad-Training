# 002 – Verifica accesso utente con ruolo ed età  
🔽 English version included below

---

## ✅ Obiettivo

Simulare un **controllo di accesso** basato sul **ruolo dell’utente** (`admin`, `user`, `guest`)  
e sull’età inserita da tastiera. Mostrare messaggi diversi a seconda delle condizioni logiche combinate.

---

## 💡 Concetti

- `Console.ReadLine()` → input da tastiera  
- `ToLower()` → standardizza l’input per evitare errori di confronto  
- `int.Parse()` → converte la stringa età in numero intero  
- `if/else` → struttura condizionale  
- operatori logici `&&` e `||` → combinazione di più condizioni  
- `const` → valore fisso non modificabile (`etaMinima`)  
- `bool` → gestione dello stato di accesso

---

## 🧠 Focus tecnico

- Simulare una logica di accesso basata su **parametri multipli**  
- Scrivere condizioni composte e leggibili  
- Riconoscere il ruolo dell’utente (`admin`, `user`, `guest`) e reagire di conseguenza  
- ⚠️ In questo script **non è ancora previsto alcun controllo sull’input dell’utente**:  
  - Se l’utente inserisce un’età non numerica (`es. "venti"`), si verificherà una **eccezione di tipo `FormatException`**  
  - Lo stesso vale se viene lasciato vuoto l’input, o se si inserisce un ruolo non riconosciuto  
- ➕ Questo è un buon punto di partenza per **familiarizzare con gli errori a runtime**,  
  che impareremo a intercettare e gestire con meccanismi di validazione nei prossimi esercizi

---

## 📄 Codice

```csharp
void Main()
{
    const int etaMinima = 18;

    Console.WriteLine("Inserisci il tuo ruolo (admin, user, guest):");
    string ruolo = Console.ReadLine().ToLower();

    Console.WriteLine("Inserisci la tua età:");
    int eta = int.Parse(Console.ReadLine());

    bool accessoConsentito = false;

    if (ruolo == "admin")
    {
        accessoConsentito = true;
    }
    else if (ruolo == "user" && eta >= etaMinima)
    {
        accessoConsentito = true;
    }

    if (accessoConsentito)
    {
        Console.WriteLine("✅ Accesso consentito.");
    }
    else
    {
        Console.WriteLine("❌ Accesso negato.");
    }
}
```
---

# 002 – User access verification based on role and age (English version)

---

## ✅ Objective

Simulate a simple **access control system** based on the user's **role** (`admin`, `user`, `guest`)  
and their age entered from the keyboard. Display different messages depending on combined logical conditions.

---

## 💡 Concepts

- `Console.ReadLine()` → reads input from the keyboard  
- `ToLower()` → standardizes input to avoid comparison errors  
- `int.Parse()` → converts the input string to an integer  
- `if/else` → conditional logic  
- logical operators `&&` and `||` → combine multiple conditions  
- `const` → defines a fixed, immutable value (`minimumAge`)  
- `bool` → stores the access status

---

## 🧠 Technical focus

- Simulate access logic using **multiple parameters**  
- Write compound and readable conditions  
- Recognize the user role (`admin`, `user`, `guest`) and react accordingly  
- ⚠️ This script **does not yet include any input validation**:  
  - If the user enters a non-numeric age (e.g. `"twenty"`), a **`FormatException`** will be thrown  
  - The same applies if the input is left empty or a role not handled by the logic is provided  
- ➕ This is a great opportunity to **start getting familiar with runtime errors**,  
  which we will learn to detect and manage properly in upcoming exercises


---

## 📄 Code

```csharp
void Main()
{
    const int minimumAge = 18;

    Console.WriteLine("Enter your role (admin, user, guest):");
    string role = Console.ReadLine().ToLower();

    Console.WriteLine("Enter your age:");
    int age = int.Parse(Console.ReadLine());

    bool accessGranted = false;

    if (role == "admin")
    {
        accessGranted = true;
    }
    else if (role == "user" && age >= minimumAge)
    {
        accessGranted = true;
    }

    if (accessGranted)
    {
        Console.WriteLine("✅ Access granted.");
    }
    else
    {
        Console.WriteLine("❌ Access denied.");
    }
}

