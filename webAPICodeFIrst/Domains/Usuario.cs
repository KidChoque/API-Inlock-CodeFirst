using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webAPICodeFIrst.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)]//Cria um índice único 
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage = "Email obrigatório")]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha obrigatória")]
        [StringLength(20,MinimumLength =6,ErrorMessage = "Senha de mínimo 6 e máximo 20 caracteres")]
        public string Senha { get; set; }

        //Refereância da chave estrangeira (Tabela Estudio)
        [Required(ErrorMessage = "Estudio produtor do jogo obrigatório")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("{IdTipoUsuario}")]
        public TipoUsuario? TipoUsuario { get; set; }

    }
}
