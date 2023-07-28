using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class PointsOfInterestForUpdate
    {
        [Required(ErrorMessage="You should put a valid name!")]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }

    }
}
