using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ETU.Domain.Common;

namespace ETU.Domain.Entities
{
    [Table("ActivityType", Schema = "entity")] // Tablo adı ve şeması belirtiliyor
    public class ActivityType : BaseEntity
    {   
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan birincil anahtar
        public int ID { get; set; } */

        [Required]
        [MaxLength(500)]
        public string Name { get; set; } = string.Empty;

        // İlişkili Activity entity'si (isteğe bağlı, eğer ilişki varsa)
        // public virtual ICollection<Activity> Activities { get; set; }
    }
}