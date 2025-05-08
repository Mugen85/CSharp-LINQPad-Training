# 010 – Uso di `var`: inferenza del tipo, valore e costruzione  
🔽 English version included below this section

---

## ✅ Obiettivo

Comprendere il funzionamento di `var` in C# come forma di **inferenza del tipo**.  
Osservare come il tipo viene dedotto automaticamente dal valore assegnato  
e cosa succede quando cambiano i tipi assegnati.

---

## 💡 Concetti

- `var` → parola chiave per dichiarare variabili con tipo dedotto  
- inferenza statica → il tipo è determinato dal compilatore in fase di compilazione  
- il tipo non può cambiare dopo l’inizializzazione  
- i metodi chiamabili dipendono dal tipo dedotto  
- errore in compilazione se il tipo è ambiguo o nullo (`var x = null;` → ❌)

---

## 🧠 Focus tecnico

- Dichiarazione di variabili con `var` e tipi primitivi (`int`, `string`, `double`)  
- Uso di `GetType()` per verificare il tipo effettivo  
- Comprendere che `var` non è "dinamico" come in altri linguaggi  
- Riflessione: **`var` è utile, ma richiede consapevolezza del tipo sottostante**  
- ⚠️ In contesti formativi è bene usare `var` solo quando il tipo è chiaro e leggibile

---

## 📄 Codice

```csharp
void Main()
{
    var nome = "Marco";
    var eta = 30;
    var altezza = 1.78;

    Console.WriteLine(nome.GetType());     // System.String
    Console.WriteLine(eta.GetType());      // System.Int32
    Console.WriteLine(altezza.GetType());  // System.Double
}
```
---

# 010 – Using `var`: type inference, value and construction (English version)

---

## ✅ Objective

Understand how `var` works in C# as a form of **type inference**.  
Observe how the type is automatically deduced from the assigned value,  
and what happens when different types are involved.

---

## 💡 Concepts

- `var` → keyword for declaring variables with inferred type  
- static inference → type is resolved at compile time  
- the type cannot change after initialization  
- available methods depend on the inferred type  
- compile-time error if the type is ambiguous or null (`var x = null;` → ❌)

---

## 🧠 Technical focus

- Declare variables with `var` and primitive types (`int`, `string`, `double`)  
- Use `GetType()` to verify the actual type  
- Understand that `var` is not dynamic (like in JavaScript or Python)  
- Important: **`var` is helpful, but requires awareness of the underlying type**  
- ⚠️ In educational contexts, it's best to use `var` only when the type is obvious and readable

---

## 📄 Code

```csharp
void Main()
{
    var name = "Marco";
    var age = 30;
    var height = 1.78;

    Console.WriteLine(name.GetType());     // System.String
    Console.WriteLine(age.GetType());      // System.Int32
    Console.WriteLine(height.GetType());   // System.Double
}
