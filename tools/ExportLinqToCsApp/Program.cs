// ExportLinqToCsApp - Programma Console C# per convertire .linq in .cs
// Obiettivo: sostituire lo script PowerShell con una soluzione C# coerente col progetto

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

			string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

			Log(logPath, $"[START] {timestamp} - Inizio conversione\n");

			// ✅ Uso del metodo VerificaPercorso
			if (!VerificaPercorso(scriptsPath, "scripts") || !VerificaPercorso(outputPath, "github-view"))
				return;

			Directory.CreateDirectory(outputPath);

			int count = 0;

			foreach (string file in Directory.GetFiles(scriptsPath, "*.linq", SearchOption.AllDirectories))
			{
				string fileName = Path.GetFileName(file);
				string newFileName = Path.ChangeExtension(fileName, ".cs");
				string relativePath = Path.GetRelativePath(scriptsPath, file);
				string subfolder = Path.GetDirectoryName(relativePath); // es. "real-world" o ""

				string outputSubfolder = Path.Combine(outputPath, subfolder ?? "");
				Directory.CreateDirectory(outputSubfolder);

				string outputFile = Path.Combine(outputSubfolder, newFileName);

				string[] lines = File.ReadAllLines(file);

				DateTime now = DateTime.Now;
				DateTime lastModified = File.GetLastWriteTime(file);
				TimeSpan delta = now - lastModified;

		//funzione legata al tempo attivata per modifica con sottocartella nuova /real-world
				if (delta.TotalSeconds < 2 || delta.TotalMinutes > 30)
				{
				//Console.WriteLine($"⏱ Ignorato per timing: {fileName} (modificato {delta.TotalSeconds:N0} sec fa)");
					continue;
				}

				var builder = new StringBuilder();
				builder.AppendLine($"    // ⚠️ ATTENZIONE: questo file è stato generato automaticamente");
				builder.AppendLine($"    // Non modificarlo manualmente: verrà sovrascritto ad ogni esecuzione.");
				builder.AppendLine($"    // File sorgente: {fileName}");
				builder.AppendLine($"    // Data generazione: {timestamp}");
				builder.AppendLine("namespace GeneratedSnippets");
				builder.AppendLine("{");

				string className = Path.GetFileNameWithoutExtension(file).Replace("-", "_");
				builder.AppendLine($"    public class {className}");
				builder.AppendLine("    {");
				builder.AppendLine("        public static void Main()");
				builder.AppendLine("        {");

				foreach (var line in lines)
				{
					var cleanLine = line.TrimStart('\uFEFF', ' ', '\t').Trim();
					if (cleanLine.StartsWith("<query", StringComparison.OrdinalIgnoreCase))
						continue;

					builder.AppendLine("            " + cleanLine);
				}

				builder.AppendLine("        }");
				builder.AppendLine("    }");
				builder.AppendLine("}");

				string newContent = builder.ToString();

				// Se il file .cs esiste, confronto i contenuti
				if (File.Exists(outputFile))
				{
					string existingContent = File.ReadAllText(outputFile);
					if (existingContent == newContent)
					{
						Console.WriteLine($"🟡 Nessuna modifica: {fileName}");
						continue;
					}
				}

				File.WriteAllText(outputFile, newContent, Encoding.UTF8);
				Log(logPath, $"✅ {fileName} → {newFileName}");
				Console.WriteLine($"✅ Convertito: {fileName}");
				count++;
			}

			// ✅ Messaggio finale
			if (count > 0)
			{
				Console.WriteLine($"\n✅ Conversione completata. File convertiti: {count}\n");
				Log(logPath, $"[END] File totali convertiti: {count}\n");
			}
			else
			{
				Console.WriteLine("\nℹ️ Nessun file da convertire. Tutto aggiornato.\n");
				Log(logPath, $"[END] Nessun file convertito. Tutto aggiornato.\n");
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
