using Microsoft.AspNetCore.Identity;

namespace JWTAutheticationAPI.Data.Domain
{
    public class AppUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
