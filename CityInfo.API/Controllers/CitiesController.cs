using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        /*[HttpGet]
        public JsonResult getCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }*/
        [HttpGet]
        public ActionResult<IEnumerable<CityDtl>>  GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }


        [HttpGet("{id}")]
        public ActionResult<CityDtl> getCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == id);
            if (cityToReturn == null)
            {
                NotFound();
            }
            return Ok(cityToReturn);
           // return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == id));
        }
    }
}
