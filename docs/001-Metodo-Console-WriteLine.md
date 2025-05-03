# 001 – Metodo Console.WriteLine  
🔽 English version included below this section

---

## ✅ Obiettivo

Comprendere il funzionamento del metodo `Console.WriteLine`, che consente di stampare messaggi sulla console dell’applicazione.  
È uno degli strumenti fondamentali per comunicare con l’utente e per il debug.

---

## 💡 Concetti

- `Console` → classe statica del framework .NET per input/output su console
- `WriteLine()` → metodo che stampa una stringa seguita da un ritorno a capo
- stringa tra virgolette → testo letterale da visualizzare
- punto e virgola (`;`) → obbligatorio a fine istruzione

---

## 🧠 Focus tecnico

- Chiamata a un metodo statico tramite il nome della classe (`Console`)
- Comprendere la differenza tra `WriteLine()` e `Write()`
- Introduzione all’output su console
- Attenzione alla corretta sintassi: parentesi tonde e punto e virgola

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("Benvenuto nel mio primo programma!");
}
