using GerenciadorDeRendaDomain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeRendaInfra.Context.Configurações
{
    public class ConfigurationConta : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            
            builder
             .HasMany(e => e.Entrada)
             .WithOne(c => c.Conta)
            .OnDelete(DeleteBehavior.Cascade);
            builder
           .HasMany(s => s.Saida)
           .WithOne(c => c.Conta)
          .OnDelete(DeleteBehavior.Cascade);

            builder
               .Property(c => c.DataCriacao)
               .HasDefaultValueSql("now()");
            builder
                .Property(c => c.DataAlteracao)
                .HasDefaultValueSql("now()");


        }
    }
}
