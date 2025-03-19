namespace Shamilova_ObrazPlus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            MaterialProduct = new HashSet<MaterialProduct>();
        }

        [Key]
        public int IdMaterial { get; set; }

        [Required]
        [StringLength(255)]
        public string NameMaterial { get; set; }

        public int MaterialTypeId { get; set; }

        public double UnitPrice { get; set; }

        public int CountInStock { get; set; }

        public int MinimumCount { get; set; }

        public int CountPerPackage { get; set; }

        [Required]
        [StringLength(255)]
        public string UnitOfMeasurement { get; set; }

        public virtual MaterialType MaterialType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialProduct> MaterialProduct { get; set; }
    }
}
