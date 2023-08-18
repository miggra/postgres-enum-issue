using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresEnumPrototype.Data.Entities;

[Table("messages")]
public class Message
{
    [Column("id", Order = 0)]
    [Required]
    public Guid Id { get; set; }

    [Column("recipient_id", Order = 1)]
    [Required]
    public Guid RecipientId { get; set; }

    [Column("subject", Order = 2)]
    public string Subject { get; set; }

    [Column("body", Order = 3)]
    [Required]
    public string Body { get; set; }

    [Column("send_date_time", TypeName = "timestamp with time zone", Order = 4)]
    [Required]
    public DateTimeOffset SendDateTime { get; set; }

    [Column("delivery_status", Order = 5, TypeName = "delivery_status")]
    [Required]
    public DeliveryStatus DeliveryStatus { get; set; }
}