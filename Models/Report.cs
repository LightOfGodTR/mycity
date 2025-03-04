using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommercePlatform.Models
{
public class Report
{
    public int ReportId { get; set; }
    public string Title { get; set; }
    public DateTimeOffset GeneratedDate { get; set; }
    public string GeneratedBy { get; set; }  
    public string Content { get; set; }  

}
}