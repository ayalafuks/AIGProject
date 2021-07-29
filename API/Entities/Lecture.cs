namespace API.Entities
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Deccription { get; set; }
        public string Source { get; set; }
        public string Image { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public Category Category { get; set; }
        public bool IsFavorite { get; set; }
    }
}