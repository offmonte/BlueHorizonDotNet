using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GameForum.DTOs
{
    public class AvaliacaoDTO
    {
        [Required]
        [Range(1, 10)]
        public int Cassification { get; set; }
        [Required]
        public string TxtAvaliation { get; set; }
    }
}
