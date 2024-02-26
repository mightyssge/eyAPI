using Microsoft.EntityFrameworkCore;


namespace eyAPI.Models
{
    public class ProviderContext : DbContext
    {
        public ProviderContext (DbContextOptions<ProviderContext> options): base(options)
        {
            
        }
        public DbSet<Provider> Providers { get; set; }
    }
}
