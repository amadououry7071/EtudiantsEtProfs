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
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Etudiant e)
        {
            db = new EtudProdDbContext();

            db.etudiants.Add(new Etudiant { Name = e.Name, interet=e.interet });
            db.SaveChanges();

            return View();
        }
    }
}