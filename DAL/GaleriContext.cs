using DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class GaleriContext:DbContext
    {
        public GaleriContext()
        {
            
        }
        public GaleriContext(DbContextOptions<GaleriContext> options):base(options)
        {

        }

        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Model> Modelller { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseOracle("User Id = galeri; Password = galeri; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SID = orcl)))");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Marka_CFG());
            modelBuilder.ApplyConfiguration(new Model_CFG());
            modelBuilder.ApplyConfiguration(new Araba_CFG());
        }

    }
}