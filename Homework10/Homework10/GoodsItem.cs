using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement
{
    public class GoodsItem
    {
        [Key]
        public string ItemId { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public GoodsItem()
        {
            ItemId = Guid.NewGuid().ToString();
        }

        public GoodsItem(string id, string product, double unitPrice, int quantity)
        {
            ItemId = id;
            Product = product;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
