using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity
{
    public class Image : BaseEntity
    {
        [Required]
        public string Path { get; set; }

        public int PostID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
    }
}
