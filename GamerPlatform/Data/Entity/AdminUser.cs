using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entity
{
    public class AdminUser : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
