using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ETU.Domain.Common;

namespace ETU.Domain.Entities
{
    [Table("Institution", Schema = "entity")] // Tablo adı ve şeması belirtiliyor
    public class Institution : BaseEntity
    {
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan birincil anahtar
        public int ID { get; set; } */

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string AzureGroupId { get; set; } = string.Empty; // NULL olabilir

        // İlişkili Activity entity'si (isteğe bağlı, eğer ilişki varsa)
        // public virtual ICollection<Activity> Activities { get; set; }
    }
}