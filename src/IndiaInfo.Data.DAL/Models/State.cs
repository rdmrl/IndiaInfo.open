using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IndiaInfo.Data.DAL.Models
{
    [Table("State", Schema = "Core")]
    public class State
    {
        public int StateId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage="The name must be provided."), MaxLength(50, ErrorMessage = "The name must be 50 characters or less.")]
        public string Name { get; set; }

        [Required]
        [StringLength(1)]
        [Column("DivisionType", TypeName="char(1)")]
        public char DivisionType { get; set; }

        [Required]
        [StringLength(5)]
        [Column("IsoCode", TypeName="char(5)")]
        public string IsoCode { get; set; }

        [Required]
        [StringLength(2)]
        [Column("VehicleCode", TypeName="char(2)")]
        public string VehicleCode { get; set; }

        public DateTime StatehoodDate { get; set; }

        [StringLength(1)]
        [Column("AdminZone", TypeName="char(1)")]
        public string AdminZone { get; set; }
    }
}
