namespace MVCAssignment1.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MVCAssignment1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCAssignment1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCAssignment1.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            ApplicationUser adminUser = null;
            if (!context.Users.Any(p => p.UserName == "admin@myblogapp.com"))
            {
                adminUser = new ApplicationUser();
                adminUser.UserName = "admin@myblogapp.com";
                adminUser.Email = "admin@myblogapp.com";

                userManager.Create(adminUser, "blogadmin");
            }
        }
    }
}
