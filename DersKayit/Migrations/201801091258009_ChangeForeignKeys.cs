namespace DersKayit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ders", "HocaId", "dbo.Hocas");
            DropIndex("dbo.Ders", new[] { "HocaId" });
            RenameColumn(table: "dbo.Ders", name: "HocaId", newName: "Hoca_HocaId");
            AddColumn("dbo.Ders", "Bolum_BolumId", c => c.Int());
            AddColumn("dbo.Ogrencis", "Bolum_BolumId", c => c.Int());
            AddColumn("dbo.Hocas", "Bolum_BolumId", c => c.Int());
            AlterColumn("dbo.Ders", "Hoca_HocaId", c => c.Int());
            CreateIndex("dbo.Ders", "Bolum_BolumId");
            CreateIndex("dbo.Ders", "Hoca_HocaId");
            CreateIndex("dbo.Hocas", "Bolum_BolumId");
            CreateIndex("dbo.Ogrencis", "Bolum_BolumId");
            AddForeignKey("dbo.Ders", "Bolum_BolumId", "dbo.Bolums", "BolumId");
            AddForeignKey("dbo.Hocas", "Bolum_BolumId", "dbo.Bolums", "BolumId");
            AddForeignKey("dbo.Ogrencis", "Bolum_BolumId", "dbo.Bolums", "BolumId");
            AddForeignKey("dbo.Ders", "Hoca_HocaId", "dbo.Hocas", "HocaId");
            DropColumn("dbo.Ders", "BolumId");
            DropColumn("dbo.Ogrencis", "BolumId");
            DropColumn("dbo.Hocas", "BolumId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hocas", "BolumId", c => c.Int(nullable: false));
            AddColumn("dbo.Ogrencis", "BolumId", c => c.Int(nullable: false));
            AddColumn("dbo.Ders", "BolumId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Ders", "Hoca_HocaId", "dbo.Hocas");
            DropForeignKey("dbo.Ogrencis", "Bolum_BolumId", "dbo.Bolums");
            DropForeignKey("dbo.Hocas", "Bolum_BolumId", "dbo.Bolums");
            DropForeignKey("dbo.Ders", "Bolum_BolumId", "dbo.Bolums");
            DropIndex("dbo.Ogrencis", new[] { "Bolum_BolumId" });
            DropIndex("dbo.Hocas", new[] { "Bolum_BolumId" });
            DropIndex("dbo.Ders", new[] { "Hoca_HocaId" });
            DropIndex("dbo.Ders", new[] { "Bolum_BolumId" });
            AlterColumn("dbo.Ders", "Hoca_HocaId", c => c.Int(nullable: false));
            DropColumn("dbo.Hocas", "Bolum_BolumId");
            DropColumn("dbo.Ogrencis", "Bolum_BolumId");
            DropColumn("dbo.Ders", "Bolum_BolumId");
            RenameColumn(table: "dbo.Ders", name: "Hoca_HocaId", newName: "HocaId");
            CreateIndex("dbo.Ders", "HocaId");
            AddForeignKey("dbo.Ders", "HocaId", "dbo.Hocas", "HocaId", cascadeDelete: true);
        }
    }
}
