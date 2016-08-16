using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Model
{
    [Table("Books")]
    public  class Libro
    {
        [Key]
        [Column("title_id")] 
        public int  id_titulo{get; set;}
        [Required]
        [StringLength(100)]
        [Column("title")]
        public string titulo { get; set; }

        [Required ]
        [StringLength(30)]
        [Column("type")]
        public string tipo { get; set; }
        [Column("pub_id")]
        public int id_pud { get; set; }

        [Required]
        [Column("price")]
        public decimal precio { get; set; }

        [StringLength(30)]
        [Column("advance")]
        public string avanzar { get; set; }
        [Column("royalty")]
        public int familia { get; set; }

        [Column("ytd_sales")]
        public decimal ventas_ytd { get; set; }
        [StringLength(200)]
        [Column("notes")]
        public string notas { get; set; }
        [Required ]
        [Column("pubdate")]
        public DateTime fechapub { get; set; }

        public virtual ICollection<LibroAutor> LibroAutor { get; set; }
    }
}
