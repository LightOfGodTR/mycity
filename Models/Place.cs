using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommercePlatform.Models
{
public class Place
{
    public int PlaceId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Description { get; set; }
}


}