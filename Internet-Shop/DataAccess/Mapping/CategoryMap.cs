using Internet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Internet_Shop.DataAccess.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories");
            HasMany(x => x.Products); //связь с товарами
            HasKey(x => x.Id); //первичный ключ

        }
    }
}