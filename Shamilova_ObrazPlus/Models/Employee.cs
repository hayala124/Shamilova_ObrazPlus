namespace Shamilova_ObrazPlus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int IdEmployee { get; set; }

        public double CodeEmployee { get; set; }

        public int JobTitleId { get; set; }

        [Required]
        [StringLength(255)]
        public string Surname { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(255)]
        public string Login { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        public string TimeLastEntrance { get; set; }

        public int EntranceTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string EmployeeImagePath { get; set; }

        public virtual EntranceType EntranceType { get; set; }

        public virtual JobTitle JobTitle { get; set; }
    }
}
