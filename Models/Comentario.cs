using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameForum.Models
{
    [Table("Tabela_De_Comentarios")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UseId { get; set; }
        [ForeignKey("UseId")]
        public Usuario? Usuario { get; set; }
        [Required]
        public int AvaliationId { get; set; }
        [ForeignKey("AvaliationId")]
        public Avaliacao? Avaliacao { get; set; }
        [Required]
        public int JogoId { get; set; }
        [ForeignKey("JogoId")]
        public Jogo? Jogo { get; set; }
        [Required]
        [Column("Texto_Do_Comentario")]
        public string TxtComment { get; set; }
        [Required]
        [Column("Data_do_Comentario")]
        public DateTime CommentDate { get; set; }
    }
}
