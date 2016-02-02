using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity.Address
{
    [Table("Address_County")]
    public class County
    {
        public int CountyID { get; set; }
        public string CountyName { get; set; }
        public int CityID { get; set; }
    }
}
