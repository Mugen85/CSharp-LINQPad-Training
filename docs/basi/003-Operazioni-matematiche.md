# 003 – Operazioni matematiche  
🔽 English version included below this section

---

## ✅ Obiettivo

Comprendere come eseguire operazioni matematiche di base in C# tra numeri, usando operatori aritmetici standard.

---

## 💡 Concetti

- `+` → somma  
- `-` → sottrazione  
- `*` → moltiplicazione  
- `/` → divisione  
- `%` → resto (modulo)  

---

## 🧠 Focus tecnico

- Uso degli operatori aritmetici tra variabili di tipo numerico  
- Distinzione tra `int` e `double` per evitare errori di divisione  
- Assegnazione del risultato a nuove variabili  
- Uso di `Console.WriteLine` per mostrare i risultati  

---

## 📄 Codice

```csharp
void Main()
{
    int a = 10;
    int b = 3;

    int somma = a + b;
    int differenza = a - b;
    int prodotto = a * b;
    double divisione = (double)a / b;
    int resto = a % b;

    Console.WriteLine($"Somma: {somma}");
    Console.WriteLine($"Differenza: {differenza}");
    Console.WriteLine($"Prodotto: {prodotto}");
    Console.WriteLine($"Divisione: {divisione}");
    Console.WriteLine($"Resto: {resto}");
}
```
# 003 – Math operations  
🔼 Italian version above

---

## ✅ Goal

Understand how to perform basic math operations in C# between numbers, using standard arithmetic operators.

---

## 💡 Concepts

- `+` → addition  
- `-` → subtraction  
- `*` → multiplication  
- `/` → division  
- `%` → remainder (modulo)  

---

## 🧠 Technical focus

- Using arithmetic operators between numeric variables  
- Difference between `int` and `double` to avoid division errors  
- Assigning the result to new variables  
- Using `Console.WriteLine` to display results  

---

## 📄 Code

```csharp
void Main()
{
    int a = 10;
    int b = 3;

    int sum = a + b;
    int difference = a - b;
    int product = a * b;
    double division = (double)a / b;
    int remainder = a % b;

    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Difference: {difference}");
    Console.WriteLine($"Product: {product}");
    Console.WriteLine($"Division: {division}");
    Console.WriteLine($"Remainder: {remainder}");
}
