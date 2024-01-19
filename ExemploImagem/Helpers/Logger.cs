
namespace ExemploImagem.Helpers
{
    public static class Logger
    {
        private static string _logFile = "log.txt";

        public static void Log(string message, string nomeMetodo, string stackTrace)
        {
            try
            {
                string diretorioPrincipal = FileSystem.Current.AppDataDirectory;
                string caminhoCompleto = Path.Combine(diretorioPrincipal, _logFile);

                using (StreamWriter sw = File.AppendText(caminhoCompleto))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - {nomeMetodo} - {stackTrace} - {message}");
                }
            }
            catch (Exception ex)
            {
                //Se o log não funcionar, não temos muito o que fazer...
            }
        }
    }
}
