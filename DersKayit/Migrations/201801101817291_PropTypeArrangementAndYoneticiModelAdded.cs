namespace DersKayit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropTypeArrangementAndYoneticiModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yoneticis",
                c => new
                    {
                        YoneticiId = c.Int(nullable: false, identity: true),
                        YoneticiAd = c.String(),
                        YoneticiSoyad = c.String(),
                        YoneticiNo = c.Int(nullable: false),
                        Sifre = c.String(),
                        Rol = c.String(),
                    })
                .PrimaryKey(t => t.YoneticiId);
            
            AlterColumn("dbo.Hocas", "HocaNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hocas", "HocaNo", c => c.String());
            DropTable("dbo.Yoneticis");
        }
    }
}
