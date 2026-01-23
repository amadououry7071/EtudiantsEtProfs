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
        public ActionResult Index(string Name)
        {
            db=new EtudProdDbContext();
            var ceci=db.etudiants.Where(m=>m.Name==Name);
            if (ceci.Any()) 
            {
                Session["name"]=Name;
                return RedirectToAction("index", "SameInterest");
            }
            var cec=db.profs.Where(m => m.Name == Name);
            if(cec.Any()) 
            {
                //
            }
                return View();
        }
    }
}