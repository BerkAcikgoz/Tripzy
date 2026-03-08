using System;

namespace Tripzy.Core.Entity
{
  public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
 }