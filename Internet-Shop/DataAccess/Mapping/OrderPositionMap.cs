using Internet_Shop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Internet_Shop.DataAccess.Mapping
{
    public class OrderPositionMap : EntityTypeConfiguration<OrderPosition>
    {
        public OrderPositionMap()
        {
            ToTable("OrderPositions");
            HasKey(x => x.Id);
            HasRequired(x => x.Product);
            HasRequired(x => x.Order);

        }
    }
}