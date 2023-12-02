namespace tp.Models
{
    public class MovieViewModel
    {
        public string Name { get; set; }
        public Guid? Genre_Id { get; set; }
        public string? GenreName { get; set; }
        public IFormFile? MoviePicture { get; set; }
    }
}
