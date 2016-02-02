using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity.Address
{
    [Table("Address_City")]
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }        
    }
}
