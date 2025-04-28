using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ETU.Domain.Common;

namespace ETU.Domain.Entities
{
    [Table("PropertyBag", Schema = "entity")] // Tablo adı ve şeması belirtiliyor
    public class PropertyBag : BaseEntity
    {
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan birincil anahtar
        public int ID { get; set; } */

        [Required]
        [MaxLength(200)]
        public string PropertyKey { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string PropertyValue { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        // İlişkili entity'ler (eğer varsa) buraya eklenebilir.
        // PropertyBag'in başka tablolarla bir ilişkisi olmaması muhtemeldir,
        // ancak eğer varsa buraya navigation property'leri ekleyebilirsiniz.
    }
}