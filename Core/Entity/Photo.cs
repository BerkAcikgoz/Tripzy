using System;

namespace Tripzy.Core.Entity
{
    public class Photo
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }

        public int? UploadedByUserId { get; set; }

        public string Url { get; set; }

        public DateTime CreatedDate { get; set; }

        public Place Place { get; set; }

        public User UploadedByUser { get; set; }
    }
}