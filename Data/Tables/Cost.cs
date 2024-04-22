using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Tables;

[Table("Cost")]
public class Cost
{
    [Key]
    public int CostId { get; set; }
    public string Item { get; set; }
    public double Price { get; set; }
    public string Vendor { get; set; }
    public Uri? Link { get; set; }
}