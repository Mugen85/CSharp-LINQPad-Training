# 013 – Commenti: singoli, multipli e utilizzo  
🔽 English version included below this section

---

## ✅ Obiettivo

Comprendere l’uso dei **commenti in C#**:  
sia i commenti su singola riga (`//`) sia quelli su più righe (`/* ... */`).  
Capire perché sono fondamentali nella scrittura di codice leggibile e mantenibile.

---

## 💡 Concetti

- `//` → commento a **singola riga**  
- `/* ... */` → commento a **blocco multiplo di righe**  
- i commenti **non influenzano** l’esecuzione del programma  
- servono per **spiegare il codice** a sé stessi o ad altri  
- buona pratica: commentare codice complesso, intenzioni, fix temporanei

---

## 🧠 Focus tecnico

- Uso pratico dei due tipi di commento  
- Commentare istruzioni per disattivarle temporaneamente  
- Annotare il significato di un blocco di codice  
- ⚠️ Evitare commenti inutili o ovvi  
- ✔️ Un buon commento spiega il “perché”, non solo il “cosa”

---

## 📄 Codice

```csharp
void Main()
{
    // Questo è un commento su una sola riga
    Console.WriteLine("Eseguito con commento singolo sopra");

    /*
        Questo è un commento su
        più righe. Utile per spiegazioni
        più lunghe o blocchi disattivati.
    */
    Console.WriteLine("Eseguito dopo commento multiplo");

    // Console.WriteLine("Questa riga è disattivata");
}
```
---

# 013 – Comments: single-line, multi-line and usage (English version)

---

## ✅ Objective

Understand how to use **comments in C#**,  
both single-line comments (`//`) and multi-line block comments (`/* ... */`).  
Learn why comments are essential for writing readable and maintainable code.

---

## 💡 Concepts

- `//` → **single-line** comment  
- `/* ... */` → **multi-line** or block comment  
- comments **do not affect** program execution  
- used to **explain code** to yourself or other developers  
- best practice: comment complex logic, intentions, or temporary workarounds

---

## 🧠 Technical focus

- Use both types of comments in practice  
- Temporarily disable a line of code with a comment  
- Add notes to explain the purpose of code blocks  
- ⚠️ Avoid redundant or obvious comments  
- ✔️ A good comment explains the “why”, not just the “what”

---

## 📄 Code

```csharp
void Main()
{
    // This is a single-line comment
    Console.WriteLine("Executed with a single-line comment above");

    /*
        This is a multi-line comment.
        Useful for longer explanations
        or commenting out entire sections.
    */
    Console.WriteLine("Executed after multi-line comment");

    // Console.WriteLine("This line is commented out");
}

