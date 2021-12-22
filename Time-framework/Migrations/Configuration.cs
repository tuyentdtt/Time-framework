namespace Time_framework.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Time_framework.Models;


    internal sealed class Configuration : DbMigrationsConfiguration<Time_framework.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Time_framework.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Trang Thai 
            string IdTrangThai1 = Guid.NewGuid().ToString();
            string IdTrangThai2 = Guid.NewGuid().ToString();
            string IdTrangThai3 = Guid.NewGuid().ToString();

            IList<TrangThaiModel> defaultTrangThaiModel = new List<TrangThaiModel>();
            defaultTrangThaiModel.Add(new TrangThaiModel() {
                MaTrangThai = IdTrangThai1,
                TenTrangThai = "Prepare",
                MoTa = "Prepare",
                IsDelete = false,
            });

            defaultTrangThaiModel.Add(new TrangThaiModel()
            {
                MaTrangThai = IdTrangThai2,
                TenTrangThai = "Working",
                MoTa = "Working",
                IsDelete = false,
            });

            defaultTrangThaiModel.Add(new TrangThaiModel()
            {
                MaTrangThai = IdTrangThai3,
                TenTrangThai = "Done",
                MoTa = "Done",
                IsDelete = false,
            });

            context.TrangThaiModel.AddRange(defaultTrangThaiModel);


            /// User
            /// 

            //string IdUser1 = Guid.NewGuid().ToString();
            //string IdUser2 = Guid.NewGuid().ToString();




            //IList<ApplicationUser> defaultApplicationUser = new List<ApplicationUser>();

            //defaultApplicationUser.Add(new AppUser()
            //{
            //    Id = IdUser1,
            //    Email = "admin@gmail.com",
            //    UserName = "admin",
            //    EmailConfirmed = true,
            //    PasswordHash = "ADSpWTNPbjPWwIWhI8YKIt81Pi6SL+FOvYeKhlWZgtGp5fbrOpNKWSkIrW9JUmRAQA=="
            //});

            //defaultApplicationUser.Add(new AppUser()
            //{
            //    Id = IdUser2,
            //    Email = "staff@gmail.com",
            //    UserName = "staff",
            //    EmailConfirmed = true,
            //    PasswordHash = "ADSpWTNPbjPWwIWhI8YKIt81Pi6SL+FOvYeKhlWZgtGp5fbrOpNKWSkIrW9JUmRAQA=="
            //});

            //context.ApplicationUser.AddRange(defaultApplicationUser);

            //IList<CongViecModel> defaultCongViecModel = new List<CongViecModel>();

            //defaultCongViecModel.Add(new CongViecModel()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    MaCongViec = "Design",
            //    MaTrangThai = "IdTrangThai1"
            //});

            //defaultCongViecModel.Add(new CongViecModel()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    MaCongViec = "PM",
            //    MaTrangThai = "IdTrangThai2"
            //});

            //defaultCongViecModel.Add(new CongViecModel()
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    MaCongViec = "Writing",
            //    MaTrangThai = "IdTrangThai3"
            //});

            //context.CongViecModel.AddRange(defaultCongViecModel);

            base.Seed(context);
        }
    }
}
