using CRUDSystem.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Repository.Data.Config
{
    internal class ProductConfigration : IEntityTypeConfiguration<Producte>

    {
        public void Configure(EntityTypeBuilder<Producte> builder)
        {
            //Fluent APIs
            builder.Property(P => P.ProducteName).IsRequired().HasMaxLength(128);
            builder.Property(P => P.Description).IsRequired();
            builder.HasOne(P => P.ProducteCategory).WithMany()
               .HasForeignKey(P=> P.CategoryId);
        }
    }
}
