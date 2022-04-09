using FinancialApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancialApp.DB.Mapping;

public class CuentaMapping: IEntityTypeConfiguration<Cuenta>
{
    public void Configure(EntityTypeBuilder<Cuenta> builder)
    {
        builder.ToTable("Cuenta", "dbo");
        builder.HasKey(o => o.Id);

        builder.HasOne(o => o.TipoCuenta)
            .WithMany()
            .HasForeignKey(o => o.TipoCuentaId);
        //builder.Property(o => o.Nombre).HasField("Nombre");
    }
}