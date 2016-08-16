using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Model
{
    [Table("Authors")]
    public class Autor
    {
        [Key]
        [Column("au_id")] 
        public int IdAutor { get; set; }
        [Required ]
        [StringLength(50)]
        [Column("au_lname")]
        public string Apellido { get; set; }

        [Required ]
        [StringLength(50)]
        [Column("au_fname")]
        public string Nombre { get; set; }

        [Required ]
        [StringLength(10)]
        [Column("au_phone")]
        public string Telefono { get; set; }
        [Required ]
        [StringLength(100)]
        [Column("au_city")]
        public string Ciudad { get; set; }

        [Required ]
        [StringLength(100)]
        [Column("au_state")]
        public string Estado { get; set; }
        [Required]
        [StringLength(10)]
        [Column("au_zip")]
        public string  Zip { get; set; }
        [Required]
        [StringLength(2)]
        [Column("au_sexo")]
        public string Sexo { get; set; }
        [Required ]
        [Column("au_salary")]
        public decimal Salario { get; set; }
        [StringLength(200)]
        [Column("au_subject")]
        public string Tema { get; set; }
    }
}
