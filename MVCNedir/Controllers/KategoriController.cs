using MVCNedir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MVCNedir.Controllers
{
    public class KategoriController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        // GET: Kategori
        //Listeleme İşlemleri için Kullanılması tercih edilir
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Categories model)
        {
            db.Categories.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Duzenle(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Categories cat = db.Categories.Find(id);

            return View(cat);
        }
        [HttpPost]
        public ActionResult Duzenle(Categories abc)
        {
            db.Entry(abc).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
  
        public ActionResult Sil(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Categories cat = db.Categories.Find(id);
            db.Categories.Remove(cat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}