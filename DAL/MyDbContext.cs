using DAL.Entity;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class MyDbContext : DbContext
    {
        public DbSet<Entree> Entrees { get; set; }
        public DbSet<Produit> Produits{ get; set; }
        public DbSet<Sortie> Sorties { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Utilisateur>Utilisateurs  { get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
              optionsBuilder.UseSqlServer
                (@"Data Source=Localhost\SQLEXPRESS01;Initial Catalog=database;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
        }
       
    }
}
