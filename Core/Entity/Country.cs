using System.Collections.Generic;

namespace Tripzy.Core.Entity
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}