using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameForum.DTOs
{
    public class CadastroDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
    }
}
