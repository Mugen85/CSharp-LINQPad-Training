# 🧠 CSharp LINQPad Training

🔽 English version below

Raccolta professionale di script ed esercizi C# in LINQPad, con l'obiettivo di evolvere da sviluppatore base ad architetto software.

Ogni file è tracciato, documentato e automatizzato. La repo include:

---

## 📂 Struttura del progetto

| Cartella/File | Contenuto |
|---------------|-----------|
| `/scripts/` | Script `.linq` eseguibili in LINQPad |
| `/docs/` | Documentazione `.md` per ogni esercizio |
| `/tools/ExportLinqToCsApp/` | Tool C# per la conversione automatica `.linq → .cs` |
| `/github-view/` | File `.cs` generati per preview su GitHub |
| `.gitignore` | Esclusione di file temporanei, log, binari |
| `conversione.log` | Log automatico delle conversioni (non versionato) |

---

## 🛠 Tool incluso

### 🔹 ExportLinqToCsApp

Un'app console scritta in C# che:

- Legge tutti i file `.linq` nella cartella `/scripts`
- Crea copie `.cs` in `/github-view` con intestazione automatica
- Genera un log dettagliato (`conversione.log`)
- Può essere eseguita via `dotnet run` o pubblicata come `.exe`

📍 [Vai al codice sorgente →](tools/ExportLinqToCsApp)

---

## 🧭 Obiettivo della repository

Questa repository è parte di un percorso di crescita professionale:

> 🔁 *Dal semplice esercizio allo studio architetturale e all'automazione del codice.*

- Ogni script è pensato per fissare concetti fondamentali (OOP, cicli, condizioni, input, classi, ecc.)
- Ogni passo è documentato e automatizzabile
- Ogni decisione di struttura è pensata in ottica da architetto software

---

## 🔗 Come contribuire / evolvere

> 📌 Se stai studiando come me, puoi:

- Forkare la repo e aggiungere i tuoi esercizi
- Espandere lo script di esportazione
- Aggiungere test automatici o validazioni sui `.linq`

---

## 📣 Note finali

Questa repository è parte di un percorso pratico personale, ma curato con standard professionali.  
L’obiettivo non è solo imparare a scrivere codice, ma **strutturarlo**, **automatizzarlo**, **comunicarlo**.

---

---

# 🧠 CSharp LINQPad Training (English version)

This is a professional collection of C# scripts and exercises for LINQPad, designed to help evolve from a beginner developer to a software architect.

Every file is tracked, documented, and automated. This repository includes:

---

## 📂 Project structure

| Folder/File | Description |
|-------------|-------------|
| `/scripts/` | LINQPad `.linq` scripts |
| `/docs/` | Markdown `.md` documentation for each exercise |
| `/tools/ExportLinqToCsApp/` | C# console tool for converting `.linq → .cs` |
| `/github-view/` | Generated `.cs` files for GitHub preview |
| `.gitignore` | Excludes logs, binaries, temp files |
| `conversione.log` | Log of conversions (not versioned) |

---

## 🛠 Included tool

### 🔹 ExportLinqToCsApp

A C# console app that:

- Reads all `.linq` files from `/scripts`
- Generates `.cs` copies in `/github-view` with a header
- Logs every conversion (`conversione.log`)
- Can be run with `dotnet run` or published as `.exe`

📍 [Go to source code →](tools/ExportLinqToCsApp)

---

## 🧭 Repository purpose

This repository is part of a long-term professional growth path:

> 🔁 *From basic exercises to architectural study and code automation.*

- Each script reinforces core concepts (OOP, loops, conditions, input, classes, etc.)
- Every step is documented and automatable
- Every structural decision is made from an architectural mindset

---

## 🔗 How to contribute / grow

> 📌 If you're also learning, you can:

- Fork the repo and add your own scripts
- Expand the conversion tool
- Add automatic tests or validation for `.linq` files

---

## 📣 Final notes

This repository is part of a personal learning path, built with professional-level care.  
The goal is not just to write code, but to **structure**, **automate**, and **communicate** it.

---
