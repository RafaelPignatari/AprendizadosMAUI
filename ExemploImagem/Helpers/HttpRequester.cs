using System.Reflection;

namespace ExemploImagem.Helpers
{
    public static class HttpRequester
    {
        public static async Task<string> Get(string url)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(url);

                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Erro ao fazer requisição GET: " + ex.Message, MethodBase.GetCurrentMethod().Name, ex.StackTrace);

                return null;
            }
        }
    }
}
