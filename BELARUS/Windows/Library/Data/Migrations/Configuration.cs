using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;

namespace BELARUS.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<BELARUS.Data.Entities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(BELARUS.Data.Entities context)
        {

        }
    }
}
