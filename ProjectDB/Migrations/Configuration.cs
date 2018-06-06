namespace ProjectDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ProjectDB.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjectDB.CourseProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectDB.CourseProjectDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            User normalUser = new User
            {
                FirstName = "Test",
                LastName = "User",
                UserName = "TestUser",
                PhoneNumber = "(02)999-999-999",
                Password = "test",
                Address = "Random Location",
                Mail = "testuser@test.com"
            };

            context.User.AddOrUpdate(normalUser);
        }
    }
}
