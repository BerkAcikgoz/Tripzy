using System;
using System.Collections.Generic;

namespace Tripzy.Core.Entity
{
    public class Place
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CityId { get; set; }

        public int CategoryId { get; set; }

        public string Address { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public int? PriceLevel { get; set; }

        public DateTime CreatedDate { get; set; }

        public City City { get; set; }

        public PlaceCategory Category { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}