using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Tables;

[Table("Venue")]
public sealed class Venue
{
    [Key]
    public int VenueId { get; }
    public string VenueName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
}