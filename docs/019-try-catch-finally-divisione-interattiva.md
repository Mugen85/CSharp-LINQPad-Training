# 019 – Divisione guidata con gestione degli errori (try, catch, finally)

## 🎯 Obiettivo
🔽 English version included below

Simulare un programma di **divisione guidata** tra due numeri interi inseriti da tastiera, mostrando in modo **chiaro e didattico** il comportamento di:

- `try`: tentativo di esecuzione della logica principale
- `catch`: gestione di diversi tipi di errore (formato errato, divisione per zero, errore generico)
- `finally`: blocco che viene sempre eseguito, qualunque sia l’esito

---

## 🧠 Concetti utilizzati

- Lettura input da console con `Console.ReadLine()`
- Parsing di stringa in intero con `int.Parse()`
- Gestione delle eccezioni con `try`, `catch`, `finally`
- Messaggi chiari e formattati per spiegare il flusso del programma

---

## 🔍 Spiegazione riga per riga

### Introduzione e input
```csharp
Console.WriteLine("▶ Avvio programma di divisione guidata");
```
Stampa un messaggio iniziale per introdurre il programma.

```csharp
Console.Write("Inserisci il dividendo (numero intero): ");
string inputDividendo = Console.ReadLine();
Console.WriteLine($"✅ Hai inserito il dividendo: {inputDividendo}");
```
L’utente inserisce il primo numero. Il valore è confermato con un messaggio esplicito.

```csharp
Console.Write("Inserisci il divisore (numero intero): ");
string inputDivisore = Console.ReadLine();
Console.WriteLine($"✅ Hai inserito il divisore: {inputDivisore}");
```
L’utente inserisce il secondo numero. Anche questo viene confermato.

```csharp
Console.WriteLine("
📌 Tentativo di eseguire la divisione...");
```
Segnala l’inizio del tentativo di calcolo, prima del blocco `try`.

---

### Blocco `try`
```csharp
int dividendo = int.Parse(inputDividendo);
int divisore = int.Parse(inputDivisore);
int risultato = dividendo / divisore;
Console.WriteLine($"
✅ Risultato della divisione: {dividendo} / {divisore} = {risultato}");
```
Il programma:
- converte i due input in numeri interi (`int.Parse`)
- esegue la divisione
- stampa il risultato

Queste righe possono generare errori, per questo sono protette nel `try`.

---

### Blocchi `catch`
```csharp
catch (FormatException)
```
Questo blocco viene eseguito **se almeno uno dei due input non è un numero intero valido**.

```csharp
catch (DivideByZeroException)
```
Questo blocco viene eseguito **se il secondo numero (divisore) è zero**.

```csharp
catch (Exception ex)
```
Cattura **qualsiasi altro tipo di errore** non previsto, utile come fallback.

---

### Blocco `finally`
```csharp
finally
{
    Console.WriteLine("
ℹ️ Fine del tentativo di divisione. Questo messaggio appare sempre.");
}
```
Questo messaggio viene **sempre eseguito**, sia che ci sia stato un errore o no.

---

### Chiusura
```csharp
Console.WriteLine("
🏁 Programma terminato.");
```
Chiude il programma con un messaggio finale.

---

## ✅ Risultato atteso

Ecco tre possibili scenari:

### ✅ Caso corretto:
```
Inserisci il dividendo (numero intero): 10
Hai inserito il dividendo: 10
Inserisci il divisore (numero intero): 2
Hai inserito il divisore: 2

📌 Tentativo di eseguire la divisione...

✅ Risultato della divisione: 10 / 2 = 5

ℹ️ Fine del tentativo di divisione. Questo messaggio appare sempre.

🏁 Programma terminato.
```

### ❌ Errore di formato:
```
Inserisci il dividendo (numero intero): ciao
Hai inserito il dividendo: ciao
...

❌ Errore di formato: uno dei valori inseriti non è un numero intero valido.
...
```

### ❌ Divisione per zero:
```
Inserisci il dividendo (numero intero): 5
Inserisci il divisore (numero intero): 0
...

❌ Errore: hai provato a dividere per zero, operazione non permessa.
...
```

---
# 019 – Guided division with error handling (try, catch, finally)

## 🎯 Objective

Simulate a **guided division program** between two integers entered via keyboard, clearly showing how:

- `try`: attempts to execute the main logic
- `catch`: handles different types of errors (format error, division by zero, generic error)
- `finally`: block that **always** runs, regardless of the outcome

---

## 🧠 Concepts used

- Reading input with `Console.ReadLine()`
- Parsing string to integer with `int.Parse()`
- Exception handling using `try`, `catch`, `finally`
- Clear and structured output messages

---

## 🔍 Line-by-line explanation

### Introduction and input
```csharp
Console.WriteLine("▶ Starting guided division program");
```
Prints an introductory message.

```csharp
Console.Write("Enter the dividend (integer): ");
string inputDividend = Console.ReadLine();
Console.WriteLine($"✅ You entered the dividend: {inputDividend}");
```
User enters the first number. The value is confirmed.

```csharp
Console.Write("Enter the divisor (integer): ");
string inputDivisor = Console.ReadLine();
Console.WriteLine($"✅ You entered the divisor: {inputDivisor}");
```
User enters the second number. Also confirmed.

```csharp
Console.WriteLine("
📌 Attempting to perform division...");
```
Signals the beginning of the division process.

---

### Try block
```csharp
int dividend = int.Parse(inputDividend);
int divisor = int.Parse(inputDivisor);
int result = dividend / divisor;
Console.WriteLine($"
✅ Result: {dividend} / {divisor} = {result}");
```
Steps:
- Converts input to integers
- Performs the division
- Prints the result

This can throw exceptions, hence wrapped in `try`.

---

### Catch blocks
```csharp
catch (FormatException)
```
Executed **if either input is not a valid integer**.

```csharp
catch (DivideByZeroException)
```
Executed **if the divisor is zero**.

```csharp
catch (Exception ex)
```
Catches **any other unexpected error**.

---

### Finally block
```csharp
finally
{
    Console.WriteLine("
ℹ️ Division attempt completed. This message always appears.");
}
```
Always executes, no matter what happens.

---

### Closing
```csharp
Console.WriteLine("
🏁 Program finished.");
```
Final message at the end of the program.

---

## ✅ Expected Output

### ✅ Correct case:
```
Enter the dividend (integer): 10
You entered the dividend: 10
Enter the divisor (integer): 2
You entered the divisor: 2

📌 Attempting to perform division...

✅ Result: 10 / 2 = 5

ℹ️ Division attempt completed. This message always appears.

🏁 Program finished.
```

### ❌ Format error:
```
Enter the dividend (integer): hello
You entered the dividend: hello
...

❌ Format error: one of the inputs is not a valid integer.
...
```

### ❌ Division by zero:
```
Enter the dividend (integer): 5
Enter the divisor (integer): 0
...

❌ Error: you tried to divide by zero, which is not allowed.
...
```