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
    internal class CategoryConfiguration : IEntityTypeConfiguration<Categorey>
    {
        public void Configure(EntityTypeBuilder<Categorey> builder)
        {
            builder.Property(C => C.CategoreyName).IsRequired();
       
        }
    }
}
