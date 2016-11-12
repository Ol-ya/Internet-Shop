using Internet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Internet_Shop.DataAccess.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Orders");
            HasKey(x => x.Id);
            HasKey(x => x.OrderPosition);
            HasRequired(x => x.Customer);


        }
    }
}