using Gestao.Empresarial.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gestao.Empresarial.Infrastructure.DataProviders.Repositories.EntityConfigurations
{
    public class ConfigureCompany : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");
            builder.HasKey(c => c.Id).HasName("Id");
            builder
                .Property(c => c.CorporateName)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();
            builder
                .Property(c => c.CNPJ)
                .HasColumnType("int")
                .HasMaxLength(14)
                .IsRequired();
            builder
                .Property(c => c.CEP)
                .HasColumnType("int")
                .HasMaxLength(8)
                .IsRequired();
            builder
                .Property(c => c.Address)
                .HasColumnType("varchar(200)")
                .HasMaxLength(200)
                .IsRequired();
            builder
                .Property(c => c.AddressNumber)
                .HasColumnType("int")
                .HasMaxLength(6)
                .IsRequired();
            builder
                .Property(c => c.Email)
                .HasColumnType("varchar(70)")
                .HasMaxLength(70)
                .IsRequired();
            builder
                .Property(c => c.Phone)
                .HasColumnType("int")
                .HasMaxLength(11)
                .IsRequired();
            builder
                .Property(c => c.Site)
                .HasColumnType("varchar(70)")
                .HasMaxLength(70);
        }
    }
}
