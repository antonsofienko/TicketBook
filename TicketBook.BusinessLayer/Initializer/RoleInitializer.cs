using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TicketBook.BusinessLayer
{
  public  class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<ApplicationUser> userManger, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@gmail.com";
            string password = "ZxcQwe!23";

            if(await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }

            if(await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user") );
            }
            if(await userManger.FindByNameAsync(adminEmail) == null)
            {
                ApplicationUser admin = new ApplicationUser
                {
                    Email = adminEmail,
                    UserName = adminEmail
                };

                IdentityResult result = await userManger.CreateAsync(admin, password);

                if (result.Succeeded)
                {
                    await userManger.AddToRolesAsync(admin, new List<string> { "admin" });
                }
            }
        }
    }
}
