namespace LoginForm.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PetDetail")]
    public partial class PetDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetDetail()
        {
            Carers = new HashSet<Carer>();
        }

        [Key]
        [StringLength(5)]
        public string PetID { get; set; }

        [Required]
        [StringLength(50)]
        public string PetName { get; set; }

        public int Species { get; set; }

        public int Breed { get; set; }

        public bool Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DayOfBirth { get; set; }

        [Required]
        [StringLength(5)]
        public string OwnerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime InDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OutDate { get; set; }

        [Required]
        [StringLength(50)]
        public string MedicalRecord { get; set; }

        public bool Status { get; set; }

        public virtual Breed Breed1 { get; set; }

        public virtual Owner Owner { get; set; }

        public virtual Species Species1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carer> Carers { get; set; }
    }
}
