using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model.Pessoa
{

    [Table("PESSOA")]

    public class PessoaViewModel
    {

        [Column("PessoaId")]
        [Key]
        [Display(Name = "Código")]
        public int PessoaId { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(255)]
        public string SobreNome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        public DateTime Databatismo { get; set; }


        [DefaultValue(false)]
        public bool Anciao { get; set; }

        [DefaultValue(false)]
        public bool ServoMinisterial { get; set; }

        [DefaultValue(false)]
        public bool PioneiroRegular { get; set; }

        [DefaultValue(false)]
        public bool Ungido { get; set; }


        [MaxLength(500)]
        public string Endereco { get; set; }

        [MaxLength(500)]
        public string Congregacao { get; set; }

    }
}
