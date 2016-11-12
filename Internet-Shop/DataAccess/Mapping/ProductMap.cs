using Internet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Internet_Shop.DataAccess.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Products");
            HasKey(x => x.Id);
            HasRequired(x => x.Category);
            HasMany(x => x.OrderPosition);
        }
    }
}