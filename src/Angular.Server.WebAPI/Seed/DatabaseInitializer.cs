
using Microsoft.Extensions.DependencyInjection;
using System;

using System.Linq;

using Angular.Server.Data;
using Angular.Server.Models.DomainModels;
using Angular.Server.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Angular.Server.WebAPI.Seed
{
    public static class DatabaseInitializer
    {
        public static async Task SeedData(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                if (context.AllMigrationsApplied())
                {
                    if (!context.BaseUnits.Any())
                    {
                        context.BaseUnits.AddRange
                        (
                            new BaseUnit { Name = "Living Space" },
                            new BaseUnit { Name = "Green House" }
                        );
                        context.SaveChanges();
                    }

                    if (!context.Users.Any())
                    {
                        var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

                        var personsWithPasswords = new List<PersonWithPassword>
                        {
                            new PersonWithPassword
                            (
                                new ApplicationUser
                                {
                                    UserName = "john.doe",
                                    Email = "john.doe@sample.com",
                                    Address = "45 Long Beach Blvd, Miami"
                                },
                                new Person
                                {
                                    FirstName = "John",
                                    LastName = "Doe"
                                },
                                "NewPassword123$"
                            ),
                            new PersonWithPassword
                            (
                                new ApplicationUser
                                {
                                    UserName = "michael.jordan",
                                    Email = "michael.jordan@sample.com",
                                    Address = "15 Square Ave, London"
                                },
                                new Person
                                {
                                    FirstName = "Michael",
                                    LastName = "Jordan"
                                },
                                "FreshPassword123$"
                            )
                        };

                        foreach (var personWithPassword in personsWithPasswords)
                        {
                            var applicationUser = personWithPassword.AppUser;

                            IdentityResult result =
                                await userManager.CreateAsync(applicationUser, personWithPassword.Password);

                            if (result.Succeeded)
                            {
                                var person = personWithPassword.Person;

                                person.ApplicationUserId = applicationUser.Id;

                                context.Persons.Add(person);
                            }
                        }

                        context.SaveChanges();
                    }
                }
            }
        }
    }

    public class PersonWithPassword
    {
        public PersonWithPassword(ApplicationUser appUser, Person person, string password)
        {
            this.AppUser = appUser;
            this.Password = password;
            this.Person = person;
        }

        public ApplicationUser AppUser { get; set; }


        public Person Person { get; set; }

        public string Password { get; set; }
    }
}
