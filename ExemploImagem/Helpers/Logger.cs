
using System.Diagnostics;
using System.Reflection;

namespace ExemploImagem.Helpers
{
    public static class Logger
    {
        private static string _logFile = "log.txt";

        public static void LogInformativo(string message)
        {
            try
            {
                string caminhoCompleto = ObtemCaminhoLog();

                using (StreamWriter sw = File.AppendText(caminhoCompleto))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - {message}");
                }
            }
            catch (Exception ex)
            {
                //Se o log não funcionar, não temos muito o que fazer...
            }
        }

        public static void LogErro(string message, string nomeMetodo, string stackTrace)
        {
            try
            {
                string caminhoCompleto = ObtemCaminhoLog();

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

        public static List<string> ObtemLogs()
        {
            var listaRetorno = new List<string>();

            try
            {
                string caminhoCompleto = ObtemCaminhoLog();

                if (!File.Exists(caminhoCompleto))
                {
                    return listaRetorno;
                }

                using (StreamReader sr = File.OpenText(caminhoCompleto))
                {
                    string linha = string.Empty;
                    List<string> logs = new List<string>();

                    while ((linha = sr.ReadLine()) != null)
                    {
                        logs.Add(linha);
                    }

                    listaRetorno = logs;
                }
            }
            catch (Exception ex)
            {
                LogErro("Erro ao obter logs: " + ex.Message, MethodBase.GetCurrentMethod().Name, ex.StackTrace);
            }

            return listaRetorno;
        }

        private static string ObtemCaminhoLog()
        {
            try
            {
                string diretorioPrincipal = FileSystem.Current.AppDataDirectory;
                string caminhoCompleto = Path.Combine(diretorioPrincipal, _logFile);

                return caminhoCompleto;
            }
            catch (Exception ex)
            {
                //Se o log não funcionar, não temos muito o que fazer...

                return string.Empty;
            }            
        }
    }
}
