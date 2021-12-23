using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestioneSpesaEF.Core.Entities;

namespace GestioneSpeseEF.RepositoryEF
{
    public class Context: DbContext
    {
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Spese> Sepse { get; set; }

        public Context() : base() { }

        public Context(DbContextOptions<Context> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestioneSpeseEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Categorie>(new CategorieConfiguration());
            modelBuilder.ApplyConfiguration<Spese>(new SpeseConfiguration());
           
        }
    }
}
