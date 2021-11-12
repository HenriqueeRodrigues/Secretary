using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Pessoa
{
    [Table("Pessoa")]
    public class PessoaViewModel
    {
        [Column("PessoaId")]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Nome { get; set; }

        [MaxLength(500)]
        public string Endereco { get; set; }

        [MaxLength(500)]
        public int Idade { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool ÉBatizado { get; set; }

    }
}
