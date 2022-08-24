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

        public ManageController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            var result = _movieService.CreateAsync(movie);
            return Json(result);
        }

        [HttpGet("{year}")]
        public IActionResult GetMovieYearAsync([FromRoute] int year)
        {
            var result =  _movieService.GetByYear(year);
            return Json(result);
        }

        [HttpGet("{title}")]
        public IActionResult GetMovieTitleAsync([FromRoute] string title)
        {
            var result = _movieService.GetByName(title);
            return Json(result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Movie movie)
        {
            var result = _movieService.UpdateAsync(movie);
            return Json(result);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Movie movie)
        {
            var result = _movieService.DeleteAsync(movie);
            return Json(result);
        }
    }
}
