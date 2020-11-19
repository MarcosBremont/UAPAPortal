using System;
using System.Collections.Generic;
using System.Text;

namespace UAPAPortal.Utilitarios
{
    public class Configuracion
    {
      
        //Clases Necesarias
       

        //Server Stuff
        //private static string Server = "http://localhost:54337/";
        //private static string Server = "http://10.0.0.100:7011/";
        private static string Server = "http://api.oficable.com/";
        //private static string Server = "http://sistecsoft-001-site32.mysitepanel.net/";
        private static string ApiName = "Api/";
        public static string ServerApi = Server + ApiName;
        public static int limitLinkLenght = 295;
        internal static int timeOutLimit = 50;
        public static DateTime dtConfirmSMS;

        

        //User Stuff
        public static int id_cliente { get; set; }
        public static string cedula { get; set; }
        public static string nombre { get; set; }
        public static string direccion { get; set; }
        public static string telefono { get; set; }
        public static string celular { get; set; }
        public static string correo { get; set; }
        public static DateTime fechanaci { get; set; }
        public static int id_sexo { get; set; }
        public static string comentario { get; set; }
        public static string imagen { get; set; }
        public static string id_pais { get; set; }
        public static string id_provincia { get; set; }
        public static string id_municipio { get; set; }
        public static string istiemporeal { get; set; }
        public static string tipo_ncf { get; set; }
        public static string key { get; set; }

       
    }
}

