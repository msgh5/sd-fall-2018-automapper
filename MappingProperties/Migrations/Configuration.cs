 namespace MappingProperties.Migrations
{
    using MappingProperties.Models;
    using MappingProperties.Models.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MappingProperties.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MappingProperties.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.People.Any())
            {
                var person = new Person();
                person.DateCreated = DateTime.Now;
                person.EyeColor = "Brown";
                person.HairColor = "Black";
                person.FirstName = "Jane";
                person.LastName = "Doe";

                context.People.Add(person);

                context.SaveChanges();
            }
        }
    }
}
