using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Tables;

[Table("Invoice")]
public class Invoice
{
    [Key]
    public int InvoiceId { get; }
    public DateTime? Due { get; set; }
    public DateTime GeneratedOn { get; set; }
    public DateTime MonthAndYear { get; set; }
    public bool hasPaid { get; set; }
    
    [ForeignKey("PromoterId")]
    public Promoter Promoter { get; set; } 
    public int PromoterId { get; }
}