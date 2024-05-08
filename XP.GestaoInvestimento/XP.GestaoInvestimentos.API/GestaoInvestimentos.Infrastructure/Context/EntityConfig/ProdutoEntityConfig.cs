using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GestaoInvestimentos.Domain;

namespace GestaoInvestimentos.Infrastructure.Context.EntityConfig
{
    public class ProdutoEntityConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos", "dbo");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).HasColumnName("ID");
            builder.Property(p => p.Descricao).HasColumnName("DESCRICAO");
            builder.Property(p => p.DataCadastro).HasColumnName("DATACADASTRO");
            builder.Property(p => p.UsuarioCadastro).HasColumnName("USUARIOCADASTRO");
            builder.Property(p => p.DataAlteracao).HasColumnName("DATAALTERACAO");
            builder.Property(p => p.ValorMinimo).HasColumnName("VALORMINIMO");
            builder.Property(p => p.ValorMaximo).HasColumnName("VALORMAXIMO");
            builder.Property(p => p.TaxaJurosMensal).HasColumnName("TAXAJUROSMENSAL");
            builder.Property(p => p.TaxasExtras).HasColumnName("TAXASEXTRAS");
            builder.Property(p => p.TempoMinimoResgate).HasColumnName("TEMPOMINIMORESGATE");
            builder.Property(p => p.DataVencimento).HasColumnName("DATAVENCIMENTO");            
        }
    }
}
