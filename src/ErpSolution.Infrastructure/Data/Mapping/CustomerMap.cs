using ErpSolution.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ErpSolution.Infrastructure.Data.Mapping;

public class CustomerMap: IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> entity)
    {
        entity.ToTable("Customers");

        entity.HasKey(c => c.Id);

        entity.HasIndex(c => c.Id)
            .IsUnique()
            .HasDatabaseName("IX_Customers_Id");

        entity.Property(c => c.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        entity.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(150);

        entity.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(150);

        entity.Property(c => c.Phone)
            .HasMaxLength(15);

        entity.Property(c => c.Active)
            .IsRequired();

        entity.Property(c => c.CreatedOn)
            .IsRequired();

        entity.Property(c => c.UpdatedOn)
            .IsRequired();

    }
}