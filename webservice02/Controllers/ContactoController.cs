using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webservice02.Models;
using webservice02.Servicios;
namespace webservice02.Controllers
{
    public class ContactoController : ApiController
    {
       private Utilitaria utl;
        public ContactoController()
        {
            this.utl = new Utilitaria();
        }
        public Contacto[] Get()
        {
            return utl.GetAllContactos();
            /*return new Contacto[]{
            new Contacto 
            {
                ID=1,nombre="john B"
            },
            new Contacto 
            {
                ID=2,nombre="jaime p"
            }
            };*/
        }

        /*
        public string[] Get()
        {
            return new string[]{
            "Hello",
            "World"
            };
        }*/
    }
}
