// ExportLinqToCsApp - Programma Console C# per convertire .linq in .cs
// Obiettivo: sostituire lo script PowerShell con una soluzione C# coerente col progetto

using System;
using System.IO;
using System.Text;

namespace ExportLinqToCsApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string projectRoot = @"C:\Users\doppi\OneDrive\Documenti\GitHub\CSharp-LINQPad-Training";
			string scriptsPath = Path.Combine(projectRoot, "scripts");
			string outputPath  = Path.Combine(projectRoot, "github-view");
			string logPath     = Path.Combine(projectRoot, "conversione.log");

			Console.WriteLine($"[DEBUG] Percorso scripts: {scriptsPath}");

			string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

			Log(logPath, $"[START] {timestamp} - Inizio conversione\n");

			try
			{
				if (!Directory.Exists(scriptsPath))
				{
					Console.WriteLine($"❌ Cartella scripts non trovata: {scriptsPath}");
					return;
				}

				Directory.CreateDirectory(outputPath);

				foreach (string file in Directory.GetFiles(outputPath, "*.cs"))
				{
					File.Delete(file);
				}

				int count = 0;
				foreach (string file in Directory.GetFiles(scriptsPath, "*.linq"))
				{
					string fileName = Path.GetFileName(file);
					string newFileName = Path.ChangeExtension(fileName, ".cs");
					string outputFile = Path.Combine(outputPath, newFileName);

					string[] lines = File.ReadAllLines(file);

					var builder = new StringBuilder();
					builder.AppendLine("namespace GeneratedSnippets");
					builder.AppendLine("{");
					builder.AppendLine($"    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente");
					builder.AppendLine($"    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.");
					builder.AppendLine($"    // File sorgente: {fileName}");
					builder.AppendLine($"    // Data generazione: {timestamp}");

					// Aggiunta della struttura C# formattata
					builder.AppendLine("namespace GeneratedSnippets");
					builder.AppendLine("{");

					// Conversione nome file in nome classe (sostituisce i trattini con underscore)
					string className = Path.GetFileNameWithoutExtension(file).Replace("-", "_");
					builder.AppendLine($"    public class {className}");
					builder.AppendLine("    {");
					builder.AppendLine("        public static void Main()");
					builder.AppendLine("        {");

					// Inserimento del contenuto originale indentato
					foreach (var line in lines)
					{
						if (!string.IsNullOrWhiteSpace(line) && !line.Trim().ToLower().StartsWith("<query"))
						{
							builder.AppendLine("            " + line);
						}
					}

					// Chiusura blocchi
					builder.AppendLine("        }");
					builder.AppendLine("    }");
					builder.AppendLine("}");

					File.WriteAllText(outputFile, builder.ToString(), Encoding.UTF8);

					Log(logPath, $"✅ {fileName} → {newFileName}");
					count++;
				}

				Console.WriteLine($"\n✅ Conversione completata. File convertiti: {count}\n");
				Log(logPath, $"[END] File totali convertiti: {count}\n");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"❌ Errore: {ex.Message}");
				Log(logPath, $"❌ Errore: {ex.Message}\n");
			}

			Console.WriteLine("Premi un tasto per chiudere...");
			Console.ReadKey();
		}

		static void Log(string path, string message)
		{
			File.AppendAllText(path, message + Environment.NewLine);
		}

		static bool VerificaPercorso(string path, string nomeCartella)
		{
			if (!Directory.Exists(path))
			{
				Console.WriteLine($"❌ Cartella '{nomeCartella}' non trovata: {path}");
				return false;
			}
			return true;
		}
	}
}
