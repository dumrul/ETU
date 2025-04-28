using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ETU.Domain.Common;

namespace ETU.Domain.Entities
{
    [Table("ManagerGroup", Schema = "entity")] // Tablo adı ve şeması belirtiliyor
    public class ManagerGroup : BaseEntity
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

        // İlişkili entity'ler (eğer varsa) buraya eklenebilir.
        // Örneğin, bir ManagerGroup'a ait kullanıcılar varsa:
        // public virtual ICollection<User> Users { get; set; }
    }
}