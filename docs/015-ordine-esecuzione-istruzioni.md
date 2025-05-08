# 015 – Ordine di esecuzione delle istruzioni  
🔽 English version included below this section

---

## ✅ Obiettivo

Capire che in un programma C# le istruzioni vengono eseguite **nell’ordine in cui sono scritte**,  a meno che non siano presenti salti di flusso (`if`, `for`, metodi, return, ecc.).  
Mostrare un esempio semplice per evidenziare il comportamento sequenziale del codice.

---

## 💡 Concetti

- il codice viene eseguito **dall’alto verso il basso**  
- ogni istruzione è eseguita una dopo l’altra, in ordine  
- la struttura del programma può **modificare il flusso**, ma l’ordine predefinito è lineare  
- utile per **prevedere il comportamento del codice**  
- fondamentale per capire dove mettere un’istruzione (prima o dopo un’altra)

---

## 🧠 Focus tecnico

- Visualizzare l’ordine di esecuzione tramite `Console.WriteLine()`  
- Imparare a **prevedere l’output** leggendo il codice  
- Rendersi conto che anche **dichiarazione e uso delle variabili** seguono questo ordine  
- Allenare il pensiero sequenziale nel debugging

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("1 - Inizio");
    Console.WriteLine("2 - Esecuzione in corso...");
    Console.WriteLine("3 - Fine");
}
```
---

# 015 – Order of execution of instructions (English version)

---

## ✅ Objective

Understand that in a C# program, instructions are executed **in the order they are written**,  
unless there are control flow statements (`if`, `for`, methods, `return`, etc.).  
Show a simple example to highlight the sequential behavior of code.

---

## 💡 Concepts

- code is executed **top to bottom**  
- each instruction runs one after the other, in order  
- the program’s structure can **alter the flow**, but the default is linear  
- helpful to **predict how the program behaves**  
- essential for deciding **where to place a statement**

---

## 🧠 Technical focus

- Use `Console.WriteLine()` to visualize execution order  
- Learn to **predict output** by reading code  
- Realize that variable declaration and usage follow the same order  
- Develop sequential thinking for debugging

---

## 📄 Code

```csharp
void Main()
{
    Console.WriteLine("1 - Start");
    Console.WriteLine("2 - Executing...");
    Console.WriteLine("3 - End");
}

