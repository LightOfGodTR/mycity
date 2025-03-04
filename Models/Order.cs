using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommercePlatform.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }


        public decimal TotalOrderAmount
        {
            get { return OrderItems?.Sum(item => item.TotalPrice) ?? 0; }
        }
    }
}
