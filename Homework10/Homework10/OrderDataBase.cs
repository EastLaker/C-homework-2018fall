using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OrderManagement
{
    class OrderDataBase:DbContext
    {
        public OrderDataBase() : base("OrderDataBase")
        {

        }
        public DbSet<Order> Order { get; set; }
        public DbSet<GoodsItem> GoodsItem { get; set; }
    }
}
