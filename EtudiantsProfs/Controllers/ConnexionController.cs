using EtudiantsProfs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EtudiantsProfs.Controllers
{
    public class ConnexionController : Controller
    {
        private EtudProdDbContext db;
        // GET: Connexion
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email,string MotDePasse)
        {
            db=new EtudProdDbContext();
            var verifEtu=db.etudiants.Where(e=>e.Email==Email && e.MotDePasse==MotDePasse );
            string nom = db.etudiants.Where(e => e.Email == Email).Select(e => e.Name).FirstOrDefault();
            if (verifEtu.Any())
            {
                Session["leNom"] = nom;
                //ViewBag.messageSucces = "Verification acceptee,Merci!";
                return RedirectToAction("index", "OffreEtudiants");

            }

            else 
            {
                var cec = db.profs.Where(e => e.Email == Email && e.MotDePasse == MotDePasse);
                if (cec.Any())
                {
                    //ViewBag.messageSucces = "Verification acceptee,Merci!";
                    return RedirectToAction("index", "OffreEtudiants");
                    
                }
                else
                {
                    ViewBag.error = "Desole,veuillez reessayer";
                }

            }



            
            return View();
        }
    }
}