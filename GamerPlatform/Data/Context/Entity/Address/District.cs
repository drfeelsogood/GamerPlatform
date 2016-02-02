using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity.Address
{
    [Table("Address_District")]
    public class District
    {
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public int CountyID { get; set; }
    }
}
