using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using taller.apis.Models;

namespace taller.apis.Controllers
{
    public class publicacionesController : ApiController
    {
        

        [HttpGet]
        public IEnumerable<publicacion> Get()
        {
            tallerJFCEntities BD = new tallerJFCEntities();


            return BD.publicacion.ToList();
        }

    }
}
