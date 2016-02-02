using System;

namespace Data
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? AddDate { get; set; }        
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
