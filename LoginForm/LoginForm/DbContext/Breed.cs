namespace LoginForm.DbContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Breed")]
    public partial class Breed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Breed()
        {
            PetDetails = new HashSet<PetDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BreedID { get; set; }

        public int? SpeciesID { get; set; }

        [StringLength(50)]
        public string BreedName { get; set; }

        public virtual Species Species { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PetDetail> PetDetails { get; set; }
    }
}
