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
                    new Student { FirstMidName = "Carson",   LastName = "Alexander",
                        EnrollmentDate = DateTime.Parse("2010-09-01") },
                };
            }

        }

        public System.Data.Entity.DbSet<Phase2Nandoso.Controllers.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<Phase2Nandoso.Controllers.Specials> Specials { get; set; }

        public System.Data.Entity.DbSet<Phase2Nandoso.Controllers.Category> Categories { get; set; }
    }
}
