using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ETU.Domain.Common;

namespace ETU.Domain.Entities
{
    [Table("EventStatus", Schema = "entity")] // Tablo adı ve şeması belirtiliyor
    public class EventStatus : BaseEntity
    {
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan birincil anahtar
        public int ID { get; set; } */

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        // İlişkili Activity entity'si (isteğe bağlı, eğer ilişki varsa)
        // public virtual ICollection<Activity> Activities { get; set; }
    }
}