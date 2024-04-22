using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Tables;

[Table("Gig")]
public class Gig
{
    //TODO: Add feature for multiple sets within a single night
    [Key] 
    public int GigId { get; }

    public string Event { get; set; }
    
    public string City { get; set; }
    
    public DateTime Date { get; set; }
    
    public DateTime StartTime { get; set; }
    
    public DateTime EndTime { get; set; }
    
    public double Hours { get; set; }
    
    public double PerHourPay { get; set; }
    
    public double ExtraPay { get; set; }
    
    public bool IsConfirmed { get; set; }
    
    public bool IsElapsed { get; set; }
    
    public bool HasPaid { get; set; }
    
    [ForeignKey("Promoter")]
    public Promoter Promoter { get; set; }
    public int PromoterId { get; }
    
    [ForeignKey("Venue")]
    public Venue Venue { get; set; }
    public int VenueId { get; set; }
}