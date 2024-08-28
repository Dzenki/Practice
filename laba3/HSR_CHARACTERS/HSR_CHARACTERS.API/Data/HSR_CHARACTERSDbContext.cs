using HSR_CHARACTERS.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HSR_CHARACTERS.API.Data
{
    public class HSR_CHARACTERSDbContext: DbContext
    {
        public HSR_CHARACTERSDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        { 
            
        }

        public DbSet<CharactersType> CharactersTypes { get; set; }

        public DbSet<CharactersPath> CharactersPaths { get; set; }

        public DbSet<CharactersInformation> CharactersInformations { get; set; }
    }
}
