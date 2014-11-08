using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webservice02.Models;
using webservice02.Services;

namespace webservice02.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        //Para ejemplo # 3 - Añadir datos usando Post
        public HttpResponseMessage Post(Contact contact)
        {
            this.contactRepository.SaveContact(contact);

            var response = Request.CreateResponse<Contact>(System.Net.HttpStatusCode.Created, contact);

            return response;
        }

        //Para ejemplo # 1
        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        //Para ejemplo # 1
        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }

        //Para ejemplo # 1
        /*public Contact[] Get()
        {
            return new Contact[] 
            {
                new Contact
                {
                    Id = 1, Name = "Miguel J"
                },
                new Contact
                {
                    Id = 2, Name = "Algonso M"
                }
            };
        }*/

/*        public string[] Get()
        {
            return new string[]
            {
             "Hello",
             "World"
            };
        }
 * */
    }
}
