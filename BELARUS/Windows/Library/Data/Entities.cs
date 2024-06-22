using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.IO;

namespace BELARUS.Data
{
    public partial class Entities : DbContext
    {

        static private string s_migrationSqlitePath;
        static Entities()
        {
            s_migrationSqlitePath = $@"{System.Windows.Forms.Application.StartupPath}\DATA\BELARUS.db";
            FileInfo DbDurum = new System.IO.FileInfo(s_migrationSqlitePath);
            if (!DbDurum.Exists)
            {
                string DizinPath = $@"{System.Windows.Forms.Application.StartupPath}\DATA";
                DirectoryInfo Dizin = new DirectoryInfo(DizinPath);
                if (!Dizin.Exists)
                {
                    Dizin.Create();
                }

                DizinPath = $@"{System.Windows.Forms.Application.StartupPath}\DATA\Img";
                Dizin = new DirectoryInfo(DizinPath);
                if (!Dizin.Exists)
                {
                    Dizin.Create();
                }

                DbDurum.Create();
            }
        }

        public Entities() : base(new SQLiteConnection($"DATA Source={s_migrationSqlitePath}"), false)
        {

        }
        public Entities(DbConnection connection) : base(connection, true)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ayar>()
                .Property(p => p.SystemAd)
                .HasMaxLength(100)
                .IsRequired();
        }
        public virtual DbSet<Ayar> Ayar { get; set; }
        public virtual DbSet<Kaynak> Kaynak { get; set; }
    }
}
