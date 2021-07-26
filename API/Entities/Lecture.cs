namespace API.Entities
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Deccription { get; set; }
        public byte[] Image { get; set; }
        public Category Category { get; set; }
        public bool IsFavorite { get; set; }
    }
}