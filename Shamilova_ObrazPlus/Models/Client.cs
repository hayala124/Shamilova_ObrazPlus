namespace Shamilova_ObrazPlus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [Key]
        public int IdClient { get; set; }

        public int ClientTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string NameClient { get; set; }

        public int? DirectorId { get; set; }

        [Required]
        [StringLength(255)]
        public string EmailClient { get; set; }

        [Required]
        [StringLength(255)]
        public string PhoneClient { get; set; }

        public int AddressId { get; set; }

        public double INN { get; set; }

        public int Rating { get; set; }

        public virtual Address Address { get; set; }

        public virtual ClientDirector ClientDirector { get; set; }

        public virtual ClientType ClientType { get; set; }
    }
}
