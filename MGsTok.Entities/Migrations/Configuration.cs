namespace MGsTok.Entities.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MGsTok.Entities.Contex.MGsTOKContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;//200 den 100 e indirmeyi aktif et
            ContextKey = "MGsTok.Entities.Contex.MGsTOKContex";
        }

        protected override void Seed(MGsTok.Entities.Contex.MGsTOKContex context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
