namespace CityInfo.API.Models
{
    public class PointOfInterestDtl
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; } 
        public ICollection<PointOfInterestDtl> PointOfInterests { get; set;} = new List<PointOfInterestDtl>();
    }
}
