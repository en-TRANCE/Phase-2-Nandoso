using Phase2Nandoso.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Phase2Nandoso.Models
{
    public class Phase2NandosoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Phase2NandosoContext() : base("name=Phase2NandosoContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Phase2NandosoContext, MyConfiguration>());
        }

        public class MyConfiguration : DbMigrationsConfiguration<Phase2NandosoContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
            }
            protected override void Seed(Phase2NandosoContext context)
            {
                var menus = new List<Menu>
                {
                    new Menu { MenuName = "Quater Chicken", MenuDetail = "Small fraction, big reaction.", MenuPrice = "$8.90", CategoryID = 1 },
                    new Menu { MenuName = "Quater Chicken & Regular side", MenuDetail = "Small fraction, big reaction.", MenuPrice = "$12.90", CategoryID = 1 },
                    new Menu { MenuName = "Half Chicken", MenuDetail = "Nothing half hearted here.", MenuPrice = "$12.90", CategoryID = 1 },
                };

                foreach (Menu m in menus)
                {
                    var menuInDataBase = context.Menus.Where(
                        s =>
                             s.Category.CategoryID == m.CategoryID).SingleOrDefault();
                    if (menuInDataBase == null)
                    {
                        context.Menus.Add(m);
                    }
                }
                context.SaveChanges();

                var specials = new List<Specials>
                {
                    new Specials {SpecialsID = 1050, SpecialsName = "Quater Chicken Festival Deluxe", SpecialsDetail = "Now with special limited time discount!", SpecialPrice = "$6.90", MenuID = 1},
                    new Specials {SpecialsID = 1050, SpecialsName = "Half Chicken Festival Deluxe", SpecialsDetail = "Now with special limited time discount!", SpecialPrice = "$10.90", MenuID = 3}
                };
                specials.ForEach(s => context.Specials.AddOrUpdate(p => p.MenuID, s));
                context.SaveChanges();

                var categories = new List<Category>
                {
                    new Category { CategoryID = 1, CategoryName = "Flame-grilled chicken"},
                    new Category { CategoryID = 2, CategoryName = "Meals to share"},

                };
                categories.ForEach(s => context.Categories.AddOrUpdate(p => p.CategoryID, s));
                context.SaveChanges();
            }

        }

        public System.Data.Entity.DbSet<Phase2Nandoso.Controllers.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<Phase2Nandoso.Controllers.Specials> Specials { get; set; }

        public System.Data.Entity.DbSet<Phase2Nandoso.Controllers.Category> Categories { get; set; }
    }
}
