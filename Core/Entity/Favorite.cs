using System;

namespace Tripzy.Core.Entity
{
    public class Favorite
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PlaceId { get; set; }

        public DateTime CreatedDate { get; set; }

        public User User { get; set; }

        public Place Place { get; set; }
    }
}