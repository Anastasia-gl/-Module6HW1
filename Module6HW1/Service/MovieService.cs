using Module6HW1.Interface.Service;
using Module6HW1.Interface.Store;
using Module6HW1.Model;
namespace Module6HW1.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieStore _movieStore;

        public MovieService(IMovieStore movieStore)
        {
            _movieStore = movieStore;
        }

        public IList<Movie> GetByName(string title)
        {
            return _movieStore.GetEntityTitle().Where(t => t.Title == title).ToList();
        }

        public IList<Movie> GetByYear(int year)
        {
            return _movieStore.GetEntityYear().Where(t => t.Year == year).ToList();
        }
    }
}
