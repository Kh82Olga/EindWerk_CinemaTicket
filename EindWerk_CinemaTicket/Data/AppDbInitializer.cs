using EindWerk_CinemaTicket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace EindWerk_CinemaTicket.Data
{
    public class AppDbInitializer
    {
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope= applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User)) await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<User>>();
                string adminUserEmail = "admin@cinematicket.com";
                var adminUser = await userManager.FindByNameAsync(adminUserEmail);
                if (adminUser==null)
                {
                    var newAdminUser = new User()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser,"Johnny1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }
                string simpleUserEmail = "user@cinematicket.com";
                var simpleUser = await userManager.FindByNameAsync(simpleUserEmail);
                if (simpleUser == null)
                {
                    var newSimpleUser = new User()
                    {
                        FullName = "Application User",
                        UserName = "simple-user",
                        Email = simpleUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newSimpleUser, "Johnny1234?");
                    await userManager.AddToRoleAsync(newSimpleUser, UserRoles.User);
                }
            }
        }
    }
}
