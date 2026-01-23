using EtudiantsProfs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EtudiantsProfs.Controllers
{
    public class SameInterestController : Controller
    {
        private EtudProdDbContext db=new EtudProdDbContext();
        // GET: SameInterest
        public ActionResult Index()
        {
            string nom = Session["name"].ToString();
            string cour = db.etudiants.Where(c => c.Name == nom).Select(i=>i.Interet).SingleOrDefault();
            var resul=db.profs.Where(p=>p.Cour == cour).ToList();
            return View(resul);
        }
    }
}