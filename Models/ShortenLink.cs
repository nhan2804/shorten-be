using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationX.Models
{
    public class Shorten
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "OriginalLink field is required")]
        [Column(TypeName = "text")]
        public string OriginalLink { get; set; } = "";
        
        [Required(ErrorMessage = "CodeLink field is required")]
        [Column(TypeName = "text")]
        public string CodeLink { get; set; } = "";
        [Column(TypeName = "int")]
        public int CountAccess { get; set; }

        [Column(TypeName = "int")]
        public int Status { get; set; }

        [Column(TypeName = "text")]
        public int Password { get; set; }
    }

}
