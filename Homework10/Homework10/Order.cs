using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement
{
    class Order
    {
        [Key]
        public String OrderId { get; set; }
        public String Customer { get; set; }
        public DateTime CreateTime { get; set; }
        public List<GoodsItem> Items { get; set; }

        public Order()
        {
            Items = new List<GoodsItem>();
        }

        public Order(string id, string customer, DateTime createTime, List<GoodsItem> items)
        {
            OrderId = id;
            Customer = customer;
            CreateTime = createTime;
            Items = items;
        }
    }
}
