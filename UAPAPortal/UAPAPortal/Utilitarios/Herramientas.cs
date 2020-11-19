using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UAPAPortal.Utilitarios
{
    public class Herramientas
    {
        public async Task<string> EjecutarSentenciaEnApiLibre(string Method, bool check = false)
        {
            string sentencia = Configuracion.ServerApi + Method;
            string request = "";

            HttpClient usuario = new HttpClient();
            var response = await usuario.GetAsync(sentencia);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                request = jsonString.ToString();
                // await RevisarTiempoDeSesion(jsonString);
            }

            return request;
        }

    }
}
