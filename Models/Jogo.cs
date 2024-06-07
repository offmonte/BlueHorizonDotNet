using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameForum.Models
{
    [Table("Tabela_Jogo")]
    public class Jogo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public Usuario Usuario { get; set; }
        [Required]
        [Column("Titulo_Do_Jogo")]
        public string Title { get; set; }
        [Required]
        [Column("Desenvolvedora_Do_Jogo")]
        public string Developer  { get; set; }
        [Required]
        [Column("Data_De_Publicação")]
        public DateTime PublishDate { get; set; }
        [Required]
        [Column("Genero_Do_Jogo")]
        public string Gender { get; set; }
        [Required]
        [Column("Plataforma_Do_Jogo")]
        public string Platform { get; set;}
        [Required]
        [Column("Capa_Do_Jogo")]
        public string CoverGame { get; set; }
        [Required]
        [Column("Jogo_Publicado")]
        public bool IsPublished { get; set; } = false;
        public ICollection<Avaliacao>? Avaliations { get; set; }
        public ICollection<Comentario>? comentarios { get; set; }
    }
}
