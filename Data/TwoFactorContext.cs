using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Two_FactorAuthApp.Data
{
    public class TwoFactorContext : IdentityDbContext
    {
        public TwoFactorContext()
        {
        }

        public TwoFactorContext(DbContextOptions options) : base(options)
        {
        }
    }
}
