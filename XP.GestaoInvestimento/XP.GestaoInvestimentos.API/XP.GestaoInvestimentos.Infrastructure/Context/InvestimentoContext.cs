using Microsoft.EntityFrameworkCore;
using XP.GestaoInvestimentos.Domain;
using XP.GestaoInvestimentos.Infrastructure.Context.EntityConfig;

namespace XP.GestaoInvestimentos.Infrastructure.Context
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
