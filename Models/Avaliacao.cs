using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameForum.Models
{
    [Table("Tabela_Avalicao")]
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Usuario? Usuario { get; set; }
        [Required]
        public int JogoId { get; set; }
        [ForeignKey("JogoId")]
        public Jogo? Jogo { get; set; }
        [Required]
        [Column("Classificacao_Do_Jogo")]
        [Range(1, 10)]
        public int Cassification { get; set; }
        [Required]
        [Column("Conteudo_Da_Avaliacao")]
        public string TxtAvaliation { get; set; }
        [Required]
        [Column("Data_Da_Postagem")]
        public DateTime PostDate { get; set; }
        [Required]
        public ICollection<Comentario>? Comentarios { get; set; }
    }
}
