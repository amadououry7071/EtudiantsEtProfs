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
            if (!ModelState.IsValid)
            {
                return View(e); // revient au formulaire avec erreurs
            }
            db = new EtudProdDbContext();


            if (!db.etudiants.Where(ma => ma.Email == e.Email).Any())
            {
                db.etudiants.Add(new Etudiant { Name = e.Name, Interet = e.Interet, Email = e.Email, MotDePasse = e.MotDePasse });
                db.SaveChanges();

                TempData["Success"] = "Étudiant ajouté avec succès";

                return RedirectToAction("index", "Connexion");
            }
            else
            {
                ModelState.AddModelError("Email", "Cet email existe déjà");
                return View(e);
            }
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