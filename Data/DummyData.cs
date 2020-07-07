using Microsoft.AspNetCore.Identity;
using monitor_covid19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace monitor_covid19.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            string role = "admin";

            if (await roleManager.FindByNameAsync(role) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role));
            }

            if (await userManager.FindByNameAsync("admin@system.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@system.com",
                    Email = "admin@system.com",
                    FirstName = "Admin",
                    LastName = "System",
                    PhoneNumber = "3133445566"
                };

                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, "p@ssw0rd");
                user.PasswordHash = hashed;

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }
            }
        }
    }
}