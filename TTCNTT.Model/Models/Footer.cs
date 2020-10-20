using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TTCNTT.Model.Models
{
    [Table("Footers")]
    internal class Footer
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}