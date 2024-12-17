using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models.Entity;

namespace WebApplication3.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        CvProje2Entities1 db = new CvProje2Entities1();
        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyim = db.TblDeneyimlerim.ToList();
            return PartialView(deneyim);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyalMedya.ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Egitim()
        {
            var egitim = db.TblEgitim.ToList();
            return PartialView(egitim);
        }
        public PartialViewResult Yetenek()
        {
            var yetenek = db.TblYeteneklerim.ToList();
            return PartialView(yetenek);
        }
        public PartialViewResult Sertifika()
        {
            var sertifika = db.TblAciklama.ToList();
            return PartialView(sertifika);
        }
        public PartialViewResult Hobi()
        {
            var hobi = db.TblHobilerim.ToList();
            return PartialView(hobi);
        }
        [HttpGet]
        public PartialViewResult İletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult İletisim(Tbliletisim t)
        {
           
            db.Tbliletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}