namespace CityInfo.API.Models
{
    public class CityDtl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PointOfInterestDtl> PointsOfInterest { get; internal set; }
        // public int NumberOfPointsOfInterest { get; set; }

    }
}
