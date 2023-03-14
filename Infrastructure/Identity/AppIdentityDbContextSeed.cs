using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any()) 
            {
                var user = new AppUser
                {
                    DisplayName = "Janybek",
                    Email = "janybek@test.com",
                    UserName = "janybek@test.com",
                    Address = new Address
                    {
                        FirstName = "Janybek",
                        LastName = "Ashimov",
                        Street = "10 The Street",
                        City = "Bishkek",
                        Region = "Chui",
                        ZipCode = "121213"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}