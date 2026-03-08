namespace Tripzy.Core.Dtos;

public class CityDto
{
    public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }
}