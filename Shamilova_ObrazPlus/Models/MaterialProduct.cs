namespace Shamilova_ObrazPlus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialProduct")]
    public partial class MaterialProduct
    {
        [Key]
        public int IdMaterialProduct { get; set; }

        public int MateriaId { get; set; }

        public int ProductId { get; set; }

        public int RequiredCountOfMaterial { get; set; }

        public virtual Material Material { get; set; }

        public virtual Product Product { get; set; }
    }
}
