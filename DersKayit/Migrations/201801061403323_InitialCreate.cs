namespace DersKayit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bolums",
                c => new
                    {
                        BolumId = c.Int(nullable: false, identity: true),
                        BolumAdi = c.String(),
                    })
                .PrimaryKey(t => t.BolumId);
            
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        DersId = c.Int(nullable: false, identity: true),
                        DersAdi = c.String(),
                        DersKodu = c.Int(nullable: false),
                        Kontenjan = c.Int(nullable: false),
                        OnSartVarMi = c.Boolean(nullable: false),
                        BolumId = c.Int(nullable: false),
                        HocaId = c.Int(nullable: false),
                        Ders_DersId = c.Int(),
                    })
                .PrimaryKey(t => t.DersId)
                .ForeignKey("dbo.Ders", t => t.Ders_DersId)
                .ForeignKey("dbo.Hocas", t => t.HocaId, cascadeDelete: true)
                .Index(t => t.HocaId)
                .Index(t => t.Ders_DersId);
            
            CreateTable(
                "dbo.Ogrencis",
                c => new
                    {
                        OgrenciId = c.Int(nullable: false, identity: true),
                        OgrenciAd = c.String(),
                        OgrenciSoyad = c.String(),
                        OgrenciNo = c.Int(nullable: false),
                        Sifre = c.String(),
                        Rol = c.String(),
                        BolumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgrenciId);
            
            CreateTable(
                "dbo.Hocas",
                c => new
                    {
                        HocaId = c.Int(nullable: false, identity: true),
                        HocaAd = c.String(),
                        HocaSoyad = c.String(),
                        HocaNo = c.String(),
                        Sifre = c.String(),
                        Rol = c.String(),
                        BolumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HocaId);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        Ogrenci_OgrenciId = c.Int(nullable: false),
                        Ders_DersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_OgrenciId, t.Ders_DersId })
                .ForeignKey("dbo.Ogrencis", t => t.Ogrenci_OgrenciId, cascadeDelete: true)
                .ForeignKey("dbo.Ders", t => t.Ders_DersId, cascadeDelete: true)
                .Index(t => t.Ogrenci_OgrenciId)
                .Index(t => t.Ders_DersId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ders", "HocaId", "dbo.Hocas");
            DropForeignKey("dbo.Ders", "Ders_DersId", "dbo.Ders");
            DropForeignKey("dbo.OgrenciDers", "Ders_DersId", "dbo.Ders");
            DropForeignKey("dbo.OgrenciDers", "Ogrenci_OgrenciId", "dbo.Ogrencis");
            DropIndex("dbo.OgrenciDers", new[] { "Ders_DersId" });
            DropIndex("dbo.OgrenciDers", new[] { "Ogrenci_OgrenciId" });
            DropIndex("dbo.Ders", new[] { "Ders_DersId" });
            DropIndex("dbo.Ders", new[] { "HocaId" });
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.Hocas");
            DropTable("dbo.Ogrencis");
            DropTable("dbo.Ders");
            DropTable("dbo.Bolums");
        }
    }
}
