using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using XP.GestaoInvestimentos.Domain;

namespace XP.GestaoInvestimentos.Infrastructure.Context.EntityConfig
{
    public class ClienteEntityConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes", "dbo");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).HasColumnName("ID");
            builder.Property(p => p.Nome).HasColumnName("NOME");
            builder.Property(p => p.Sobrenome).HasColumnName("SOBRENOME");
            builder.Property(p => p.Telefone).HasColumnName("TELEFONE");
            builder.Property(p => p.DataCadastro).HasColumnName("DATACADASTRO");
            builder.Property(p => p.DataNascimento).HasColumnName("DATANASCIMENTO");
            builder.Property(p => p.Email).HasColumnName("EMAIL");
        }
    }
}
