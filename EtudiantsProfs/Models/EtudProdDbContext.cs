using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EtudiantsProfs.Models
{
    public class EtudProdDbContext:DbContext
    {
        public DbSet<Etudiant> etudiants {  get; set; }
        public DbSet<Prof> profs { get; set; }

        public EtudProdDbContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EtudiantsProfs.Models.EtudProdDbContext, EtudiantsProfs.Migrations.Configuration>());
        }

    }
}