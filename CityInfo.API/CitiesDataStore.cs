using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDtl> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore(); //singleton pattern network
        public CitiesDataStore() {
            Cities = new List<CityDtl>()
            {
                new CityDtl()
                {
                    Id = 1,
                    Name = "Botosani",
                    Description="The one from north east from Moldova",
                    PointsOfInterest  = new List<PointOfInterestDtl>()
                    {
                        new PointOfInterestDtl()
                        {
                            Id = 1,
                            Name = "Monument",
                            Description = "Something made in centuries"
                        },
                        new PointOfInterestDtl()
                        {
                            Id = 2,
                            Name = "Facefood",
                            Description = "The best coffee shop"
                        }
                    }
                },
                new CityDtl()
                {
                    Id=2,
                    Name="Iasi",
                    Description = "It is from top 3 biggest cities.",
                    PointsOfInterest  = new List<PointOfInterestDtl>()
                    {
                        new PointOfInterestDtl()
                        {
                            Id = 1,
                            Name = "Mmmm",
                            Description = "sddvdvsdvsd"
                        },
                        new PointOfInterestDtl()
                        {
                            Id = 2,
                            Name = "rrr",
                            Description = "vsdfvsdvfdv"
                        }
                    }
                },
                new CityDtl()
                {
                    Id = 3,
                    Name = "Bucharest",
                    Description = "Romanian's Capital",
                    PointsOfInterest  = new List<PointOfInterestDtl>()
                    {
                        new PointOfInterestDtl() 
                        {
                            Id = 1,
                            Name = "xd",
                            Description = "xdxdxdxd"
                        },
                        new PointOfInterestDtl()
                        {
                            Id = 2,
                            Name = "xp",
                            Description = "xpxpxpxpxp"
                        }
                    }
                }
            };
        }
    }
}
