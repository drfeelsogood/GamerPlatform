using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity
{
    public class Message : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public int MemberID { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }
    }
}
