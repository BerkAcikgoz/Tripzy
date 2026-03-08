using System.Collections.Generic;

namespace Tripzy.Core.Entity
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountryId { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public Country Country { get; set; }

        public ICollection<Place> Places { get; set; }
    }
}