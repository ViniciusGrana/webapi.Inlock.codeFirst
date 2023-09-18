using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Inlock.codeFirst.manha.Domain
{
        [Table("TIposUsuario")]
    public class TipoUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Tipo de usuario é obrigatório!")]
        public string? Titulo { get; set; }
    }
}
