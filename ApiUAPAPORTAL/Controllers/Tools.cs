using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiUAPAPORTAL.Controllers
{
    public class Tools
    {
        public Tuple<string, object> ConvertirTablaEnTupla(DataTable dt, object clase)
        {
            string datos = "false";
            object lista = "";

            if (dt != null && dt.Rows.Count > 0)
            {
                datos = "true";
                lista = ConvertirTablaEnJson(dt);
            }

            return Tuple.Create(datos, lista);
        }

        public string ConvertirTablaEnJson(DataTable dt)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dt);
        }
    }
}
