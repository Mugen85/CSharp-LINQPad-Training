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
