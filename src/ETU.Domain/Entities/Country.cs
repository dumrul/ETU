using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETU.Domain.Entities
{
    [Table("Country", Schema = "entity")] // Tablo adı ve şeması belirtiliyor
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan birincil anahtar
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "char")] // Veritabanındaki char tipine karşılık gelir
        public string ISO { get; set; } = string.Empty;

        [Required]
        [MaxLength(80)]
        [Column(TypeName = "varchar")] // Veritabanındaki varchar tipine karşılık gelir
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(80)]
        [Column(TypeName = "varchar")] // Veritabanındaki varchar tipine karşılık gelir
        public string NiceName { get; set; } = string.Empty;

        [MaxLength(3)]
        [Column(TypeName = "char")] // Veritabanındaki char tipine karşılık gelir
        public string ISO3 { get; set; } = string.Empty;

        public short? NumCode { get; set; } // smallint .NET'te short karşılığıdır, nullable olabilir

        [Required]
        public int PhoneCode { get; set; }

        // İlişkili Activity entity'si (isteğe bağlı, eğer ilişki varsa)
        // public virtual ICollection<Activity> Activities { get; set; }
    }
}