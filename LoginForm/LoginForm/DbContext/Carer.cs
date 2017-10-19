namespace LoginForm.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carer")]
    public partial class Carer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carer()
        {
            PetDetails = new HashSet<PetDetail>();
        }

        [StringLength(5)]
        public string CarerID { get; set; }

        [Required]
        [StringLength(50)]
        public string CarerName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PetDetail> PetDetails { get; set; }
    }
}
