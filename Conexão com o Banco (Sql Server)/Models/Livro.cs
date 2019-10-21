using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bd.Models
{
    [Table("livro")]
    public partial class Livro
    {
        [Key]
        [Column("idlivro")]
        public int Idlivro { get; set; }
        [Required]
        [Column("nomelivro")]
        [StringLength(20)]
        public string Nomelivro { get; set; }
    }
}
