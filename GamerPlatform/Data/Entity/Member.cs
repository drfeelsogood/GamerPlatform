using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entity
{
    public class Member : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        //public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        //public string ProfileImagePath { get; set; }
        public DateTime LastLoginDate { get; set; }

        public virtual List<Post> Posts { get; set; }
        public virtual List<Message> Messages { get; set; }
    }
}
