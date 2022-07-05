using ExcelPayBackend.models;
using Microsoft.EntityFrameworkCore;

namespace ExcelPayBackend.context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<merchant> Merchants { get; set; }
        public DbSet<Iframe> Iframes { get; set; }
        public DbSet<Intention> Intentions { get; set; }
        public DbSet<ClientSecret> ClientSecrets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<merchant>().HasData(new merchant { Id=1,
            Name="Amr",
            PublicKey= "MEgCQQCow/N0auA7kNHXM8i4XEveHr+b1aGBHrdYAo9tWb51mxDbfHjB5sgdpgIW5EoA39yVzObqQSbTCXldK7zRc52fAgMBAAE=",
            SecretKey= "MIIBOwIBAAJBAKjD83Rq4DuQ0dczyLhcS94ev5vVoYEet1gCj21ZvnWbENt8eMHmyB2mAhbkSgDf3JXM5upBJtMJeV0rvNFznZ8CAwEAAQJAfzad+H5rolrq4pZFUjs4cSmqc5RYVpVJzQy5AsuoVssc6H6OHDpSaGTimR45d3yz0e6VgBLp4i4+bSj6TyJN6QIhAPDV3aaxMaQKLUQj6i2egCnjYn91/pwSXOhNZemgGnJVAiEAs2RbV3AHnEaiAHNlI3g8c/7isYtMHRAirb4J84ySDCMCIQC3bItmO6ptH3seXKQsnn1Kae5I2ZtTTwEHxHsMFm5OCQIhAI7ORjR992D9jXtEYW/yCFXiwv3JQQcl0CV1UiCyd5T3AiBdDPt0gotUwgI7MMdpaK0rmTiNlZZpkAGH+5Cu94XIZA==",
            });

        }
    }
}
