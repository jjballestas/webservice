using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webservice02.Models;

namespace webservice02.Servicios
{
    public class Utilitaria
    {
        
        public Contacto[] GetAllContactos()
        {
            return new Contacto[]{
            new Contacto 
            {
                ID=1,nombre="john B"
            },
            new Contacto 
            {
                ID=2,nombre="jaime p"
            }
            };
        }

    }
}