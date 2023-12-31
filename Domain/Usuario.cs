﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Inlock.codeFirst.manha.Domain
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]//Cria um Indice único para
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage = "Email é obrigatório!")]


        public string Email { get; set; }
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha é obrigatório!")]
        [StringLength(20, MinimumLength =6, ErrorMessage ="Senha de 6 à 20 caracteres")]
        public string Senha { get; set; }



        [Required(ErrorMessage ="Tipo do Usuário obrigatório")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario? TipoUsuario { get; set; }



    }
}
