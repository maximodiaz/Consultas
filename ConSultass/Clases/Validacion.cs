using ConSultass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConSultass.Clases
{
    public class Validacion
    {
       public periodEntities2 db = new periodEntities2();
        public Boolean Login(string usuario, string password, string perfil)
        {
            Boolean respuesta;
            //List<string> DBdatos;

            //DBdatos = db.acceso.ToList();
            foreach (var dato in db.acceso.ToList())
            {
                if (dato.usuario == usuario && dato.contraseña == password && dato.perfil == perfil)
                {
                    respuesta = true;
                    return respuesta;
                }
            }

            return respuesta = false;
            
        }
    }
}