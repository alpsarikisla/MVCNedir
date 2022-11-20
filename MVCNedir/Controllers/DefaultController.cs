using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCNedir.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]//Sayfa Açılırken
        public ActionResult Anasayfa()
        {
            return View();
        }
        [HttpPost]//Post isteği oluşmuş ise 
        public ActionResult Anasayfa(string isim, string soyisim)
        {
            return View();
        }
        [HttpGet]
        public ActionResult Listele()
        {
            List<string> liste = new List<string>();
            liste.AddRange(new string[] { "Ankara", "Adana", "Eskişehir", "İzmir", "Bursa" });
            return View(liste);
        }
    }
}