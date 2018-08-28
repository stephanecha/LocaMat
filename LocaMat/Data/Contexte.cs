using System.Data.Entity;
using LocaMat.Classes;


namespace LocaMat.Data
{
    public class Contexte : DbContext
    {
        public DbSet<Produit> Produits { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Agence> Agences { get; set; }
    }

}