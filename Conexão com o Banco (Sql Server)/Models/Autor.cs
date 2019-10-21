using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bd.Models
{
    [Table("autor")]
    public partial class Autor
    {
        [Key]
        [Column("idautor")]
        public int Idautor { get; set; }
        [Required]
        [Column("nomeautor")]
        [StringLength(20)]
        public string Nomeautor { get; set; }
    }
}
