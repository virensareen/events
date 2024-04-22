using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Tables;

[Table("Promoter")]
public sealed class Promoter
{
    [Key]
    public int PromoterId { get; }
    public string BrandName { get; set; }
    public Dictionary<string, ContactDetails> Contact { get; set; }
}

public abstract class ContactDetails
{
    public string Email { get; set; }
    public string Phone { get; set; }
}