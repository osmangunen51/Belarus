namespace BELARUS.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class IlkYukleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ayars",
                c => new
                {
                    No = c.Int(nullable: false, identity: true),
                    SystemAd = c.String(nullable: false, maxLength: 100),
                    Deger = c.String(maxLength: 2147483647),
                    Durum = c.Boolean(),
                    Tarih = c.DateTime(),
                })
                .PrimaryKey(t => t.No);

            CreateTable(
                "dbo.Kaynaks",
                c => new
                {
                    No = c.Int(nullable: false, identity: true),
                    Ad = c.String(maxLength: 2147483647),
                    Aciklama = c.String(maxLength: 2147483647),
                    Dosya = c.String(maxLength: 2147483647),
                    Tarih = c.DateTime(),
                    Durum = c.Boolean(),
                })
                .PrimaryKey(t => t.No);

        }

        public override void Down()
        {
            DropTable("dbo.Kaynaks");
            DropTable("dbo.Ayars");
        }
    }
}
