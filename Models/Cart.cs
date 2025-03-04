using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommercePlatform.Models
{
public class Cart 
{
    public int CartId { get; set; }
    public int UserId { get; set; }
    public ICollection<CartItem> Items { get; set; }

  
    public decimal TotalCartPrice
    {
        get { return Items?.Sum(item => item.TotalPrice) ?? 0; }
    }
}
}