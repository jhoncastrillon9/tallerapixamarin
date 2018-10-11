using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using taller.xamarin.Modelo;

namespace PruebaApi.Controllers
{
    public class PruebaAPiController : Controller
    {
        // GET: PruebaAPi
        public ActionResult Index()
        {
            HttpClient Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("http://localhost:65397/");
            var request = Cliente.GetAsync("api/publicaciones").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<publicacion>>(responseJson);
                
            }

            return View();
        }
    }
}