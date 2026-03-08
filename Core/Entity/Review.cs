using System;

namespace Tripzy.Core.Entity
{
    public class Review
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int PlaceId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime CreatedDate { get; set; }

        public User User { get; set; }

        public Place Place { get; set; }
    }
}