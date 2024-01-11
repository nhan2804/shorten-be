using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationX.Models
{
    public class InfoIP
    {
        [Key]
        public int IdInfo { get; set; }

        [Column(TypeName = "int")]
        public int? ShortenId { get; set; }
        [Column(TypeName = "text")]
        public string? ip { get; set; }
      
   
        [Column(TypeName = "text")]
        public string? continent { get; set; }
       
        [Column(TypeName = "text")]

        public string? country { get; set; }
       
      
        [Column(TypeName = "text")]
        public string? region { get; set; }
        [Column(TypeName = "text")]
        public string? city { get; set; }
      

        [Column(TypeName = "text")]
        public string? org { get; set; }
        [Column(TypeName = "text")]
        public string? isp { get; set; }
       
        [Column(TypeName = "text")]
        public string? currency { get; set; }
        [Column(TypeName = "text")]
        public string? currency_code { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
