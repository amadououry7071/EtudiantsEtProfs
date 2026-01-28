using EtudiantsProfs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EtudiantsProfs.Controllers
{
    public class OffreEtudiantsController : Controller
    {
        // GET: OffreEtudiants
        private EtudProdDbContext db;
        public ActionResult Index()
        {
            ViewBag.leNom = " "+Session["leNom"].ToString();
            db = new EtudProdDbContext();
            List<string> lesProfs = db.profs.Select(e=>e.Name).ToList<string>();
            return View(lesProfs);
        }
        private List<string> ChargerProfs()
        {
            return db.profs.Select(p => p.Name).ToList();
        }
        [HttpPost]
        public ActionResult Index(List<string>courPrefer,string niveauPrefer,string coursePrefer)
        {
            db = new EtudProdDbContext();
            var lesProfs = ChargerProfs();

            if ((courPrefer==null) || string.IsNullOrEmpty(niveauPrefer) || string.IsNullOrEmpty(coursePrefer))
            {
                ViewBag.error = "veuillez choisir avant de confirmer";

                return View(lesProfs);
            }
            else
            {
                ViewBag.leNom = Session["leNom"].ToString();
                ViewBag.message = "Vous avez choisis Cours: " + string.Join(", ",courPrefer) + ".Votre Niveau: " + niveauPrefer+", et l'enseignant "+coursePrefer; 
            }


                 
            

            

            return View(lesProfs);
        }

    }
}