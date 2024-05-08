using Microsoft.EntityFrameworkCore;
using GestaoInvestimentos.Domain;
using GestaoInvestimentos.Infrastructure.Context.EntityConfig;

namespace GestaoInvestimentos.Infrastructure.Context
{
    public class InvestimentoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos{ get; set; }

        public InvestimentoContext(DbContextOptions<InvestimentoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteEntityConfig());
            modelBuilder.ApplyConfiguration<Produto>(new ProdutoEntityConfig());
        }
    }
}
