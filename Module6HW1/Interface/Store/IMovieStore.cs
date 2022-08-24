using Module6HW1.Model;
namespace Module6HW1.Interface.Store
{
    public interface IMovieStore
    {
        public async Task AddAsync(Movie entity) { }

        public async Task RemoveAsync(Movie entity) { }

        public async Task EditAsync(Movie entity) { }

        public IList<Movie> GetEntityYear();

        public IList<Movie> GetEntityTitle();
    }
}
