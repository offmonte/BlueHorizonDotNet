using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueHorizon.Models
{
    [Table("Tabela_De_Atualizacoes")]
    public class Atualizacao
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Cidade")]
        public string Cidade { get; set; }

        [Required]
        [Column("Porto")]
        public string Porto { get; set; }

        [Required]
        [Column("pH")]
        public string pH { get; set; }

        [Required]
        [Column("OxigenioDissolvido")]
        public string OxigenioDissolvido { get; set; }

        [Required]
        [Column("Nitrato")]
        public string Nitrato { get; set; }

        [Required]
        [Column("Fosfato")]
        public string Fosfato { get; set; }

        [Required]
        [Column("Microplasticos")]
        public string Microplasticos { get; set; }

        [Required]
        [Column("Salinidade")]
        public string Salinidade { get; set; }

        [Required]
        [Column("DataAtualizacao")]
        public DateTime DataAtualizacao { get; set; }
    }
}
