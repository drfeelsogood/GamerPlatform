using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public int? ParentID { get; set; }
        [ForeignKey("ParentID")]
        public virtual Category Parent { get; set; }

        public virtual List<Category> TopCategory { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
