# 016 – Errori di compilazione vs runtime  
🔽 English version included below this section

---

## ✅ Obiettivo

Comprendere la differenza tra **errori di compilazione** ed **errori di runtime** in C#.  
Mostrare esempi pratici e far notare come e quando si manifestano.

---

## 💡 Concetti

- **errore di compilazione** → il codice **non può essere eseguito**  
- **errore di runtime** → il codice **compila correttamente** ma fallisce durante l’esecuzione  
- il compilatore segnala gli errori prima della build  
- gli errori di runtime si scoprono **solo quando il programma gira**

---

## 🧠 Focus tecnico

- Distinguere tra errori bloccanti e errori a esecuzione avviata  
- Riconoscere messaggi del compilatore  
- Simulare errori classici come:
  - variabile non dichiarata (compilazione)
  - divisione per zero (runtime)  
- Costruire consapevolezza per il debugging

---

## 📄 Codice

```csharp
void Main()
{
    // Esempio di errore di compilazione:
    // int numero = "testo"; // ❌ tipo errato

    // Esempio di errore di runtime:
    int x = 5;
    int y = 0;
    int risultato = x / y; // ❌ divisione per zero
    Console.WriteLine(risultato);
}
```
---

# 016 – Compilation errors vs runtime errors (English version)

---

## ✅ Objective

Understand the difference between **compilation errors** and **runtime errors** in C#.  
Show practical examples and explain when and how they occur.

---

## 💡 Concepts

- **compilation error** → the code **cannot be executed at all**  
- **runtime error** → the code **compiles correctly** but fails during execution  
- the compiler detects errors before the program runs  
- runtime errors appear **only when the program is running**

---

## 🧠 Technical focus

- Distinguish between build-time and runtime errors  
- Recognize typical compiler messages  
- Simulate common issues such as:
  - undeclared variable (compilation)
  - division by zero (runtime)  
- Build awareness for debugging and safe coding

---

## 📄 Code

```csharp
void Main()
{
    // Example of a compilation error:
    // int number = "text"; // ❌ wrong type

    // Example of a runtime error:
    int x = 5;
    int y = 0;
    int result = x / y; // ❌ division by zero
    Console.WriteLine(result);
}
