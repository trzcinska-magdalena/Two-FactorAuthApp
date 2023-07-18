using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Two_FactorAuthApp.Data
{
    public class TwoFactorContext : IdentityDbContext<IdentityUser>
    {
        public TwoFactorContext()
        {
        }

        public TwoFactorContext(DbContextOptions options) : base(options)
        {
        }
    }
}
