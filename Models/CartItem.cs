using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommercePlatform.Models
{
    public class CartItem
{
    public int CartItemId { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }  
    public Cart Cart { get; set; }

  
    public decimal TotalPrice
    {
        get { return Quantity * Price; }
    }
}
}
