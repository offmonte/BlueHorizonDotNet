using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameForum.Models
{
    [Table("Tabela_Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Nome_De_Usuario")]
        public string UserName { get; set; }
        [Required]
        [Column("Nick")]
        public string NickName { get; set; }
        [Required]
        [Column("Foto_De_Perfil")]
        public string FotoUrl { get; set; } = "https://static.vecteezy.com/ti/vetor-gratis/p3/12749491-icone-de-meme-pikachu-surpreso-gratis-vetor.jpg";
        [Required]
        [Column("Hash_da_senha")]
        public string PasswordHash { get; set; }
        [Required]
        [EmailAddress]
        [Column("Email")]
        public string UserEmail { get; set; }
        [Required]
        [Column("Data_do_registro")]
        public DateTime DateRegister { get; set; }

        public ICollection<Avaliacao>? Avaliations { get; set; }
        public ICollection<Comentario>? comentarios { get; set; }
        public ICollection<Jogo>? jogos { get; set; }
        [Required]
        [Column("Usuario_Ativo")]
        public bool IsActive { get; set; } = true;
    }
}
