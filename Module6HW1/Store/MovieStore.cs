using Module6HW1.Interface.Store;
using Module6HW1.Model;
namespace Module6HW1.Store
{
    public class MovieStore : IMovieStore
    {
        private readonly MovieContext _movieContext;

        public MovieStore(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task AddAsyns(Movie movie)
        {
            _movieContext.Add(movie);
            await _movieContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Movie movie)
        {
            _movieContext.Remove(movie);
            await _movieContext.SaveChangesAsync();
        }

        public async Task EditAsync(Movie movie)
        {
            if (movie != null)
            {
                _movieContext.Update(movie);
            }

            await _movieContext.SaveChangesAsync();
        }

        public IList<Movie> GetEntityYear()
        {
            return _movieContext.Movie.ToList();
        }
        public IList<Movie> GetEntityTitle()
        {
            return _movieContext.Movie.ToList();
        }
    }
}
