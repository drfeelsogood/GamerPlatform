using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity.Address
{
    [Table("Address_Neighborhood")]
    public class Neighborhood
    {
        public int NeighborhoodID { get; set; }
        public string NeighborhoodName { get; set; }
        public int DistrictID { get; set; }
    }
}
