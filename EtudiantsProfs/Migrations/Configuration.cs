namespace EtudiantsProfs.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EtudiantsProfs.Models.EtudProdDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed=true;    
            ContextKey = "EtudiantsProfs.Models.EtudProdDbContext";
        }

        protected override void Seed(EtudiantsProfs.Models.EtudProdDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
