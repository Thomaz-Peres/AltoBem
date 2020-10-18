using AltoBem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AltoBem.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produtos> Produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var x in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("Cadastro") != null ))
            {
                // se o EF identificar que estou inserindo algum registro, a data do cadastro, sera de hoje.
                if(x.State == EntityState.Added)
                {
                    x.Property("Cadastro").CurrentValue = DateTime.Now;
                }
                if (x.State == EntityState.Modified)
                {
                    x.Property("Cadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
