using GetOutfit.Models;
using Microsoft.EntityFrameworkCore;

namespace GetOutfit.Data
{
    public class GetOutfitContext:DbContext
    {
        public GetOutfitContext(DbContextOptions<GetOutfitContext>options):base(options)
        {
        
        }

        public DbSet<ApplyUser> ApplyUsers { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
