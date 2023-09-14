using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webAPICodeFIrst.Domains
{
    /// <summary>
    /// Classe que representa a entidade Jogo
    /// </summary>

    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do jogo é obrigatório!")]
        public string Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição do jogo obrigatória")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "Data de Lançamento do jogo obrigatória")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "Decimal(4,2)")]
        [Required(ErrorMessage = "Preço do jogo obrigatório")]
        public decimal Preco { get; set; }

        //Refereância da chave estrangeira (Tabela Estudio)

        [Required(ErrorMessage = "Estudio produtor do jogo obrigatório")]
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }

    }
}
