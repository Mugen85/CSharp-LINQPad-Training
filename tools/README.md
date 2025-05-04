# 🛠 ExportLinqToCsApp

🔽 English version below

Applicazione console scritta in **C#** per automatizzare la conversione di file `.linq` (utilizzati in LINQPad) in file `.cs` leggibili, strutturati e ben formattati per GitHub.

---

## ✅ Obiettivo del tool

Questo strumento nasce per risolvere in modo elegante e automatizzato un problema comune:

> 🧩 *Visualizzare codice LINQPad su GitHub in modo leggibile e professionale.*

Converte ogni `.linq` in un `.cs` valido, indentato correttamente e incapsulato in un `namespace` e `class`, pronto per la preview su GitHub.

---

## 🧠 Funzionalità avanzate

- 🔎 **Scansione automatica** della cartella `/scripts`
- 🚫 Esclusione della riga `<Query Kind="Program" />` (tipica di LINQPad)
- 🎯 Conversione solo di file modificati **recentemente**
  - ✅ Tra **30 secondi** e **5 minuti fa**
  - ⏱ File troppo nuovi o troppo vecchi vengono ignorati
- 📝 Generazione **header automatico** con:
  - Nome del file sorgente
  - Timestamp della conversione
- 🧠 Ristrutturazione del codice in:
  - `namespace GeneratedSnippets`
  - `public class NomeClasse { public static void Main() { ... } }`
- 📋 **Verifica contenuti:** se il file `.cs` esiste e ha lo stesso contenuto → non viene riscritto
- 📄 Log dettagliato (`conversione.log`) generato automaticamente

---

## 📁 Struttura del progetto

| Percorso | Contenuto |
|----------|-----------|
| `scripts/` | File `.linq` sorgente creati con LINQPad |
| `github-view/` | File `.cs` convertiti e visibili su GitHub |
| `tools/ExportLinqToCsApp/` | Codice sorgente dell'applicazione |
| `conversione.log` | Log delle conversioni (non versionato) |

---

## 🚀 Esecuzione

### 🧪 In modalità sviluppo

Apri un terminale e spostati nella cartella:

```bash
cd tools/ExportLinqToCsApp
dotnet run
```

---

# 🛠 ExportLinqToCsApp (English version)

Console application written in **C#** to automatically convert `.linq` files (used in LINQPad) into clean, structured, and well-formatted `.cs` files for GitHub preview.

---

## ✅ Purpose of the tool

This utility solves a common problem in a clean and automated way:

> 🧩 *Displaying LINQPad code properly and professionally on GitHub.*

It converts each `.linq` file into a valid `.cs` file, properly indented and wrapped inside a `namespace` and `class`, ready to be previewed.

---

## 🧠 Advanced features

- 🔎 **Automatic scan** of the `/scripts` folder
- 🚫 Skips the line `<Query Kind="Program" />` (specific to LINQPad)
- 🎯 Converts only recently modified files:
  - ✅ Between **30 seconds** and **5 minutes ago**
  - ⏱ Skips files that are too new or too old
- 📝 Adds an **auto-generated header** including:
  - Original file name
  - Conversion timestamp
- 🧠 Reformats code into:
  - `namespace GeneratedSnippets`
  - `public class ClassName { public static void Main() { ... } }`
- 📋 **Content check:** if the `.cs` file already exists and is identical, it won't be overwritten
- 📄 Automatically generates a detailed log (`conversione.log`)

---

## 📁 Project structure

| Path | Description |
|------|-------------|
| `scripts/` | Source `.linq` files created with LINQPad |
| `github-view/` | Converted `.cs` files to preview on GitHub |
| `tools/ExportLinqToCsApp/` | Source code of this tool |
| `conversione.log` | Log of conversions (not versioned) |

---

## 🚀 How to run

### 🧪 Development mode

Open a terminal and navigate to the folder:

```bash
cd tools/ExportLinqToCsApp
dotnet run

