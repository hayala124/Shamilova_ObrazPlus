namespace Shamilova_ObrazPlus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            MaterialProduct = new HashSet<MaterialProduct>();
        }

        [Key]
        public int IdProduct { get; set; }

        public int ProductTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string NameProduct { get; set; }

        public int ArticleNumber { get; set; }

        public double MinimumCostForPartner { get; set; }

        [StringLength(255)]
        public string PathImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialProduct> MaterialProduct { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
