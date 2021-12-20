namespace Time_framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CommentModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MaCongViec = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NguoiTao = c.String(),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                        MoTap = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        IsModifile = c.Boolean(nullable: false),
                        MaCongViec_Fk_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CongViecModels", t => t.MaCongViec_Fk_ID)
                .Index(t => t.MaCongViec_Fk_ID);
            
            CreateTable(
                "dbo.CongViecModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CongVietSubModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MaCongViec = c.String(),
                        MaCongViec_Sub = c.String(),
                        MaTrangThai = c.String(),
                        TenCongViec_Sub = c.String(),
                        MoTa = c.String(),
                        NguoiThucHien = c.String(),
                        NgayBatDau = c.DateTime(nullable: false),
                        NgayKetThuc = c.DateTime(nullable: false),
                        SoGioThucHien = c.Int(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NguoiTao = c.String(),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        IsView = c.Boolean(nullable: false),
                        NgayKetThucCV = c.DateTime(nullable: false),
                        MaCongViec_Fk_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CongViecModels", t => t.MaCongViec_Fk_ID)
                .Index(t => t.MaCongViec_Fk_ID);
            
            CreateTable(
                "dbo.DuAnModels",
                c => new
                    {
                        MaDuAn = c.String(nullable: false, maxLength: 128),
                        TenDuAn = c.String(),
                        NgayBatDau = c.DateTime(nullable: false),
                        NgayKetThuc = c.DateTime(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                        NguoiTao = c.String(),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiSua = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaDuAn);
            
            CreateTable(
                "dbo.FileDinhKemModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MaFile = c.String(),
                        TenFile = c.String(),
                        MaCongViec = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NguoiTao = c.String(),
                        DuongDanFile = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LichModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(),
                        Slot = c.String(),
                        CongViecId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LichSuModels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MaCongViec = c.String(),
                        TieuDe = c.String(),
                        NoDung = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NguoiTao = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhongBanModels",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(),
                        NgayTao = c.DateTime(nullable: false),
                        NgaySua = c.DateTime(nullable: false),
                        NguoiTao = c.String(),
                        NguoiSua = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.TrangThaiModels",
                c => new
                    {
                        MaTrangThai = c.String(nullable: false, maxLength: 128),
                        TenTrangThai = c.String(),
                        MoTa = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaTrangThai);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.CongVietSubModels", "MaCongViec_Fk_ID", "dbo.CongViecModels");
            DropForeignKey("dbo.CommentModels", "MaCongViec_Fk_ID", "dbo.CongViecModels");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.CongVietSubModels", new[] { "MaCongViec_Fk_ID" });
            DropIndex("dbo.CommentModels", new[] { "MaCongViec_Fk_ID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.TrangThaiModels");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PhongBanModels");
            DropTable("dbo.LichSuModels");
            DropTable("dbo.LichModels");
            DropTable("dbo.FileDinhKemModels");
            DropTable("dbo.DuAnModels");
            DropTable("dbo.CongVietSubModels");
            DropTable("dbo.CongViecModels");
            DropTable("dbo.CommentModels");
        }
    }
}
