using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiUAPAPORTAL.Models;

namespace ApiUAPAPORTAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        [HttpGet("SetMaterias/{idmaterias},{nombremateria}")]
        public ActionResult<string> SetMaterias(int idmaterias, string nombremateria)
        {
            try
            {
                new Materias().IMaterias(idmaterias, nombremateria);
                return "True";
            }
            catch (Exception)
            {
                return "False";
            }
        }
    }
}
