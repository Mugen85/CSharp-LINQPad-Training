# 001 – Calcolatore sconto carrello (Cart Discount Calculator)
🔽 English version below

## 🎯 Obiettivo

Simulare un sistema di calcolo del totale di un carrello con logica di sconto multiplo:
- sconto del 10% se il totale supera i 100€
- sconto aggiuntivo del 10% con codice promozionale (es. SUMMER10)

Il tutto mantenendo il codice altamente leggibile, estensibile e fedele ai principi di *Clean Code* di Robert C. Martin.

---

## 🧠 Principi Clean Code applicati

- **SRP (Single Responsibility Principle)**: ogni classe ha un solo motivo di cambiare
- **OCP (Open/Closed Principle)**: le logiche di sconto sono estendibili tramite interfacce
- **Nomina parlante**: ogni nome descrive esattamente il suo ruolo
- **Funzioni brevi e pure**: ogni metodo è leggibile e testabile
- **Separazione netta tra logica e output**

---

## 🧱 Struttura del codice

### 🔹 `Prodotto`
Classe modello con proprietà `Nome`, `PrezzoUnitario` e `Quantità`. Calcola il totale riga.

### 🔹 `ISconto`
Interfaccia per definire strategie di sconto.

### 🔹 `ScontoQuantità`, `ScontoCodice`, `NessunoSconto`
Implementazioni concrete di sconto, ognuna con una logica separata.

### 🔹 `CalcolatoreCarrello`
Classe che applica tutte le strategie di sconto e calcola il totale.

### 🔹 `VisualizzatoreCarrello`
Classe separata per la stampa dell’output (SRP).

---

## 🧪 Esempio di output

```
🛒 Carrello:
- Libro Clean Code: 2 x €35,99 = €71,98
- Mouse Logitech: 1 x €24,50 = €24,50
- Tazza C#: 1 x €12,00 = €12,00
Totale con sconti applicati: €96,29
```

---

## 🧩 Estensioni future

- Aggiungere un `ScontoFedeltà`
- Validazione input utente con messaggi personalizzati
- Integrazione con file `.json` o lettura da database/mock

---

# 001 – Cart Discount Calculator

## 🎯 Goal

Simulate a system for calculating a shopping cart total with multiple discount rules:
- 10% discount if total exceeds €100
- Additional 10% discount if a promo code is used (e.g., SUMMER10)

All while keeping the code highly readable, extensible, and compliant with *Clean Code* principles by Robert C. Martin.

---

## 🧠 Clean Code Principles Applied

- **SRP (Single Responsibility Principle)**: each class has one reason to change
- **OCP (Open/Closed Principle)**: discount strategies are extendable via interfaces
- **Meaningful naming**: every name describes its intent
- **Short and pure functions**: every method is readable and testable
- **Clear separation between logic and output**

---

## 🧱 Code Structure

### 🔹 `Prodotto`
Model class with `Nome`, `PrezzoUnitario`, and `Quantità` properties. Computes the row total.

### 🔹 `ISconto`
Interface to define discount strategies.

### 🔹 `ScontoQuantità`, `ScontoCodice`, `NessunoSconto`
Concrete discount implementations, each with isolated logic.

### 🔹 `CalcolatoreCarrello`
Class that applies all discount strategies and calculates the total.

### 🔹 `VisualizzatoreCarrello`
Dedicated class for printing output (SRP).

---

## 🧪 Sample Output

```
🛒 Cart:
- Clean Code Book: 2 x €35.99 = €71.98
- Logitech Mouse: 1 x €24.50 = €24.50
- C# Mug: 1 x €12.00 = €12.00
Total with discounts applied: €96.29
```

---

## 🧩 Future Extensions

- Add a `LoyaltyDiscount`
- Input validation with user-friendly messages
- Integration with `.json` file input or database/mock loading


