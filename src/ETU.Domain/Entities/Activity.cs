using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETU.Domain.Entities
{
    [Table("Activity", Schema = "entity")] // Tablo adı ve şeması belirtiliyor
    public class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan birincil anahtar
        public int ID { get; set; }

        [Required]
        [MaxLength(500)]
        public string ActivityName { get; set; } = string.Empty;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(2)]
        public string StartDay { get; set; } = string.Empty;

        [Required]
        [MaxLength(2)]
        public string EndDay { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string ActivityMonth { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string ActivityYear { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nchar")] // Veritabanındaki nchar tipine karşılık gelir
        public string City { get; set; } = string.Empty;

        [Required]
        [ForeignKey("ActivityType")] // İlişkili tablo belirtiliyor (varsa)
        public int ActivityTypeId { get; set; }
        // public virtual ActivityType ActivityType { get; set; } // Navigation property (varsa)

        [Required]
        [ForeignKey("HeadOfDelegationTitle")] // İlişkili tablo belirtiliyor (varsa)
        public int HeadOfDelegationTitleId { get; set; }
        // public virtual HeadOfDelegationTitle HeadOfDelegationTitle { get; set; } // Navigation property (varsa)

        [Required]
        [ForeignKey("EventStatus")] // İlişkili tablo belirtiliyor (varsa)
        public int EventStatusId { get; set; }
        // public virtual EventStatus EventStatus { get; set; } // Navigation property (varsa)

        [Required]
        [ForeignKey("Institution")] // İlişkili tablo belirtiliyor (varsa)
        public int InstitutionId { get; set; }
        // public virtual Institution Institution { get; set; } // Navigation property (varsa)

        [MaxLength(2000)]
        public string Notes { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Country")] // İlişkili tablo belirtiliyor (varsa)
        public int CountryId { get; set; }
        // public virtual Country Country { get; set; } // Navigation property (varsa)

        [Required]
        [MaxLength(200)]
        public string CreatedBy { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        [MaxLength(200)]
        public string ModifiedBy { get; set; } = string.Empty;

        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}