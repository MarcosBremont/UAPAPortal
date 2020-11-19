using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ApiUAPAPORTAL.Models
{
    public class Conexion
    {
        private string connection = Startup.Configuraciones.GetConnectionString("ConexionDB");
        private MySqlConnection con;

        public Conexion()
        {
            con = new MySqlConnection(connection);
        }



        public MySqlConnection GetCon()
        {
            return con;
        }
        //abrir conexion con el servidor
        public void Conectar()
        {
            try
            {
                // si el estado de la conexion es cerrada la abrimos
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception)
            {
            }
        }
        //cerrar conexion con el servidor
        public void Desconectar()
        {
            try
            {
                // si el estado de la conexion es cerrada la abrimos
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
