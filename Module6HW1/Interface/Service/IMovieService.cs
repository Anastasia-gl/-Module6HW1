using Module6HW1.Model;
namespace Module6HW1.Interface.Service
{
    public interface IMovieService
    {
        public IList<Movie> GetByName(string title);

        public IList<Movie> GetByYear(int year);
    }
}
