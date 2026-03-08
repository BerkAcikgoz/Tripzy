using System.Collections.Generic;

namespace Tripzy.Core.Entity
{
    public class PlaceCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Place> Places { get; set; }
    }
}