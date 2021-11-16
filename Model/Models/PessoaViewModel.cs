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
      

        [MaxLength(500)]
        public string Endereco { get; set; }

        [MaxLength(500)]
        public int Idade { get; set; }

        [DefaultValue(false)]
        public bool ÉBatizado { get; set; }

    }
}
