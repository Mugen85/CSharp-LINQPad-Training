# 003 – Tabellina di un numero fino a un limite scelto  
🔽 English version included below

---

## ✅ Obiettivo

Stampare la **tabellina** di un numero intero scelto dall’utente,  
fino a un limite anch’esso definito tramite input da tastiera.

---

## 💡 Concetti

- `Console.ReadLine()` → acquisizione di input testuale  
- `int.Parse()` → conversione da stringa a intero  
- `for` → ciclo per iterare da 1 fino al limite incluso  
- `*` → moltiplicazione tra numero e contatore  
- interpolazione `$""` → formattazione leggibile dell’output

---

## 🧠 Focus tecnico

- Raccogliere **due input consecutivi** da parte dell’utente  
- Applicare un **ciclo `for`** controllato da un limite dinamico  
- Calcolare `numero x i` per ogni `i` da 1 al limite  
- Stampare ogni riga della tabellina in modo chiaro  
- ⚠️ In questo esercizio **non è ancora presente la validazione dell’input**  
  ➕ Se l’utente inserisce testo anziché un numero intero (`es. "ciao"`), verrà sollevata una **`FormatException`**  
  ➕ Se viene inserito un numero negativo o 0 come limite, il comportamento può essere **logicamente errato o inatteso**  
  👉 Affronteremo più avanti come **proteggere l’applicazione dagli input errati** in modo robusto

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("Inserisci il numero di cui vuoi calcolare la tabellina:");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine("Fino a quale numero vuoi arrivare?");
    int limite = int.Parse(Console.ReadLine());

    Console.WriteLine($"Ecco la tabellina del {numero} fino a {limite}:");

    for (int i = 1; i <= limite; i++)
    {
        int risultato = numero * i;
        Console.WriteLine($"{numero} x {i} = {risultato}");
    }
}
```
---

# 003 – Multiplication table up to a custom limit (English version)

---

## ✅ Objective

Print the **multiplication table** of a number entered by the user,  
up to a custom limit also provided through console input.

---

## 💡 Concepts

- `Console.ReadLine()` → get input as a string  
- `int.Parse()` → convert input to an integer  
- `for` → loop from 1 up to the user-defined limit  
- `*` → multiplication between number and loop counter  
- string interpolation `$""` → format readable output

---

## 🧠 Technical focus

- Handle **two consecutive inputs** from the user  
- Apply a `for` loop using a **dynamic upper limit**  
- Compute `number x i` for each value of `i` from 1 to `limit`  
- Print each row of the multiplication table clearly  
- ⚠️ This script **does not include input validation yet**  
  ➕ If the user enters non-numeric text (e.g. `"hello"`), a **`FormatException`** will be thrown  
  ➕ If a negative number or zero is entered as the limit, the output may be **logically incorrect or unexpected**  
  👉 In future exercises, we will learn how to **protect our programs from invalid input**

---

## 📄 Code

```csharp
void Main()
{
    Console.WriteLine("Enter the number you want to multiply:");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("Up to which number?");
    int limit = int.Parse(Console.ReadLine());

    Console.WriteLine($"Here is the multiplication table of {number} up to {limit}:");

    for (int i = 1; i <= limit; i++)
    {
        int result = number * i;
        Console.WriteLine($"{number} x {i} = {result}");
    }
}

