using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Deepika",
                    Email = "deepika@test.com",
                    UserName = "deepika@test.com",
                    Address = new Address
                    {
                        FirstName = "deepika",
                        LastName = "kulshreshtha",
                        Street = "Sectors Street",
                        City = "Noida",
                        State = "Uttar Pradesh",
                        Zipcode = "201301"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}