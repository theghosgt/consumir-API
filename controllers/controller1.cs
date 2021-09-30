using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumirAPI.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilPersonal : ControllerBase
    {
        public static string Nombre { get; private set; }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            //codigo para leer de la case de datos
            return id switch
            {
                1 => "Ivan",
                2 => "Curso",
                _ => throw new NotSupportedException("El id nos es valido")
            };
        }

        [HttpPost]
        public string Post(perfilDto PerfilPersonal)
        {
            //Guardar perfil en la base de datos


            return PerfilPersonal.Nombre;
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            //Eliminar perfil en la base de datos

            return PerfilPersonal.Nombre;
        }
        

        public class perfilDto
        {
            public string Nombre { get; set; }

            public string Apellido { get; set; }


        }

    }
}