using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult getCities()
        {
            return new JsonResult(new List<object>
            {
                new {id = 1, Name = "Botosani" },
                new {id = 2, Name = "Iasi" }
            });
        }
    }
}
