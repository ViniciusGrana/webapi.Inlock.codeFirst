using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Inlock.codeFirst.manha.Domain
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; }= Guid.NewGuid();
        [Column(TypeName ="VARCHAR (100)")]
        [Required(ErrorMessage ="Nome do jogo é obrigatório!")]
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage ="A descrição do jogo é obrigatória!")]
        public string Descricao { get; set; }
        [Column(TypeName ="DATE")]
        [Required(ErrorMessage = "Data de lançamento é obrigatório!")]
        public DateTime DataLancamento { get; set; }
        [Column(TypeName = "Decimal(4,2)")]
        [Required(ErrorMessage = "Preço é obrigatório!")]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = "Informe o estudio que produziu o jogo !")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]

        public Estudio? Estudio { get; set; } 
    }
}
