# 001 – Calcolatrice semplice con operazioni base  
🔽 English version included below

---

## ✅ Obiettivo

Creare una **calcolatrice da console** in grado di eseguire un’operazione tra due numeri inseriti dall’utente.  
Permettere all’utente di scegliere l’operatore (`+`, `-`, `*`, `/`) e visualizzare il risultato.

---

## 💡 Concetti

- `Console.ReadLine()` per acquisire input testuale  
- `int.Parse()` per convertire una stringa in numero intero  
- struttura condizionale `switch` per selezionare l’operazione  
- `if` per verificare il **caso speciale della divisione per zero**  
- variabili `bool` per **gestione dei flussi logici**  
- interpolazione `$""` per stampare il risultato

---

## 🧠 Focus tecnico

- Combinare più concetti base in un flusso coerente  
- Applicare controllo semplice sul tipo di operazione inserita  
- Verificare condizioni particolari (`numero2 == 0`)  
- ⚠️ **Non è ancora previsto il controllo del tipo di input utente**  
  ➕ Se si inserisce un carattere non numerico, verrà generata un’**eccezione**  
  👉 È un ottimo punto di partenza per **familiarizzare con gli errori a runtime**, che approfondiremo nei prossimi esercizi

---

## 📄 Codice

```csharp
void Main()
{
    Console.WriteLine("Inserisci il primo numero:");
    var input1 = Console.ReadLine();
    var numero1 = int.Parse(input1);

    Console.WriteLine("Inserisci il secondo numero:");
    var input2 = Console.ReadLine();
    var numero2 = int.Parse(input2);

    Console.WriteLine("Inserisci l'operazione da eseguire (+, -, *, /):");
    var operatore = Console.ReadLine();

    int risultato = 0;
    bool operazioneValida = true;

    switch (operatore)
    {
        case "+":
            risultato = numero1 + numero2;
            break;
        case "-":
            risultato = numero1 - numero2;
            break;
        case "*":
            risultato = numero1 * numero2;
            break;
        case "/":
            if (numero2 != 0)
            {
                risultato = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("❌ Errore: divisione per zero non consentita.");
                operazioneValida = false;
            }
            break;
        default:
            Console.WriteLine("❌ Operazione non riconosciuta.");
            operazioneValida = false;
            break;
    }

    if (operazioneValida)
    {
        Console.WriteLine($"Risultato: {numero1} {operatore} {numero2} = {risultato}");
    }
}
```

---

# 001 – Simple calculator with basic operations (English version)

---

## ✅ Objective

Create a **console-based calculator** that performs an operation between two numbers entered by the user.  
Let the user choose an operator (`+`, `-`, `*`, `/`) and display the result.

---

## 💡 Concepts

- `Console.ReadLine()` to acquire text input  
- `int.Parse()` to convert a string to an integer  
- `switch` structure to select the operation  
- `if` to check for **division by zero**  
- `bool` variable for **operation validation**  
- string interpolation `$""` to format the result

---

## 🧠 Technical focus

- Combine multiple basic concepts into a functional flow  
- Apply a simple control on the operator input  
- Detect and manage special cases (`number2 == 0`)  
- ⚠️ **No input validation is currently implemented**  
  ➕ If a non-numeric value is entered, a **runtime exception** will occur  
  👉 This is an opportunity to **start recognizing runtime errors**, which we'll learn to manage in future exercises

---

## 📄 Code

```csharp
void Main()
{
    Console.WriteLine("Enter the first number:");
    var input1 = Console.ReadLine();
    var number1 = int.Parse(input1);

    Console.WriteLine("Enter the second number:");
    var input2 = Console.ReadLine();
    var number2 = int.Parse(input2);

    Console.WriteLine("Enter the operation to perform (+, -, *, /):");
    var operation = Console.ReadLine();

    int result = 0;
    bool isValid = true;

    switch (operation)
    {
        case "+":
            result = number1 + number2;
            break;
        case "-":
            result = number1 - number2;
            break;
        case "*":
            result = number1 * number2;
            break;
        case "/":
            if (number2 != 0)
            {
                result = number1 / number2;
            }
            else
            {
                Console.WriteLine("❌ Error: division by zero is not allowed.");
                isValid = false;
            }
            break;
        default:
            Console.WriteLine("❌ Unrecognized operation.");
            isValid = false;
            break;
    }

    if (isValid)
    {
        Console.WriteLine($"Result: {number1} {operation} {number2} = {result}");
    }
}

