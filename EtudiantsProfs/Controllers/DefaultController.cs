using EtudiantsProfs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EtudiantsProfs.Controllers
{
    
    public class DefaultController : Controller
    {
        private EtudProdDbContext db;
        // GET: Default
        public ActionResult Index()
        {
            db = new EtudProdDbContext();
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Etudiant e)
        {
            db = new EtudProdDbContext();
            db.etudiants.Count();
            int a = 12;
            

           // db.etudiants.Add(new Etudiant { Name = e.Name, Interet=e.Interet });
            //db.SaveChanges();

            return RedirectToAction("index", "Connexion");
        }

        public ActionResult Index2()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Index2(Prof e)
        {
            db = new EtudProdDbContext();

            db.profs.Add(new Prof { Name = e.Name, Cour = e.Cour });
            db.SaveChanges();

            return RedirectToAction("index", "Connexion");
        }
    }
}