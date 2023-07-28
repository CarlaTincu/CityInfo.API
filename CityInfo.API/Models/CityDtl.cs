namespace CityInfo.API.Models
{
    public class CityDtl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointsOfInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
        public ICollection<PointOfInterestDtl> PointsOfInterest { get; set; }
            = new List<PointOfInterestDtl>();

    }
}
