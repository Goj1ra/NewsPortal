using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPortal.Areas.Identity.Data
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Roles.Basic.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Roles.User.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Roles.Owner.ToString()));
        }
        public static async Task SeedOwnerAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            { 
                UserName = "N0_M3rcy",
                Email = "artem_starchenko_20025@mail.ru",
                FirstName = "Artem",
                Surname = "Starchenko",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if(userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if(user == null)
                { 
                    await userManager.CreateAsync(defaultUser, "Artem-2002");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Roles.User.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Roles.Owner.ToString());
                }
            }
        }
    }
}
