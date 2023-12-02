namespace tp.Models
{
    public class Genres
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Movies>? Movies { get; set; } // Navigation property
        public Genres(string name)
        {
            Name= name;
        }
    }
}
