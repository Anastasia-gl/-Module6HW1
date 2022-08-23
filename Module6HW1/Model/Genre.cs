namespace Module6HW1.Model
{
    public class Genre
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public IList<Movie> Movies { get; set; }

        public Genre(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
