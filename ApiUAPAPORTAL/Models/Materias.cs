using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ApiUAPAPORTAL.Models
{
    public partial class Materias : Conexion
    {
        public void IMaterias(int idmaterias, string nombremateria)
        {
            using (GetCon())
            {
                DataTable dt = new DataTable();
                MySqlCommand cmd = new MySqlCommand("IMaterias", GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("prm_idmaterias", MySqlDbType.Int32).Value = idmaterias;
                cmd.Parameters.Add("prm_nombremateria", MySqlDbType.String).Value = nombremateria;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
