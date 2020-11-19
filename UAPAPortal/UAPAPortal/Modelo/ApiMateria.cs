using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UAPAPortal.Utilitarios;

namespace UAPAPortal.Modelo
{
    public class ApiMateria
    {
        Herramientas herramientas = new Herramientas();
        public ApiMateria()
        {
            // constructor
        }
        public async Task<Result> SetMaterias(int idmaterias, string nombremateria)
        {
            var result = await herramientas.EjecutarSentenciaEnApiLibre($"UAPAportal/SetMaterias/{idmaterias}/{nombremateria}");
            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<Result>(result);

            return response;
        }

    }
}
