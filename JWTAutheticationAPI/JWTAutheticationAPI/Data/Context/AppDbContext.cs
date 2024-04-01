using JWTAutheticationAPI.Data.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JWTAutheticationAPI.Data.Context
{
    public class AppDbContext(DbContextOptions options): IdentityDbContext<AppUser>(options)
    {
        
    }
}
