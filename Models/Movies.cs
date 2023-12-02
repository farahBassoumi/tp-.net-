using System.ComponentModel.DataAnnotations.Schema;

namespace tp.Models
{
    public class Movies
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ? Genre_Id { get; set; }
        public string? GenreName { get; set; }
        public Genres? Genre {  get; set; }

        [NotMapped]  
        public IFormFile ?MoviePicture { get; set; }
        public string? MoviePicturePath { get; set; }
        public ICollection<Customers>? Customers { get; set; } // Navigation property

   


    }
}
