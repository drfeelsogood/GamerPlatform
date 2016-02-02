using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity
{
    public class Post : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public bool IsExpired { get; set; }
        public int ViewCount { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string MemberAddress { get; set; }
        [Required]
        public string Status { get; set; }

        public int MemberID { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }
}
