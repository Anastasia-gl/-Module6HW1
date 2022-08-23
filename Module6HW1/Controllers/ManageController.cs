using Microsoft.AspNetCore.Mvc;
using Module6HW1.Interface.Service;
using Module6HW1.Interface.Store;
using Module6HW1.Model;
namespace Module6HW1.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class ManageController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IMovieStore _movieStore;

        public ManageController(IMovieService movieService, IMovieStore movieStore)
        {
            _movieService = movieService;
            _movieStore = movieStore;
        }

        [HttpGet]
        [Route("/GetByYear/{year}}")]
        public IActionResult GetMovieYearAsync([FromRoute] int year)
        {
            var result =  _movieService.GetByYear(year);
            return Json(result);
        }

        [HttpGet]
        [Route("/GetByName/{title}}")]
        public IActionResult GetMovieTitleAsync([FromRoute] string title)
        {
            var result = _movieService.GetByName(title);
            return Json(result);
        }

        [HttpPost]
        [Route("/Add/{movie}}")]
        public IActionResult Post([FromRoute] Movie movie)
        {
            var result = _movieStore.AddAsync(movie);
            return Json(result);
        }

        [HttpPut]
        [Route("/Update/{movie}}")]
        public IActionResult Put([FromRoute] Movie movie)
        {
            var result = _movieStore.EditAsync(movie);
            return Json(result);
        }

        [HttpDelete]
        [Route("/Delete/{movie}}")]
        public IActionResult Delete([FromRoute] Movie movie)
        {
            var result = _movieStore.RemoveAsync(movie);
            return Json(result);
        }
    }
}
