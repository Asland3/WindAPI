//using Microsoft.AspNetCore.Mvc;
//using WindAPI.Manager;
//using WindAPI.Models;

//namespace WindAPI.Controllers;

//[Route("api/[controller]")]
//[ApiController]

//public class WindDBController : Controller
//{
//    private readonly WindDBManager _windDbManager;
    
//    public WindDBController(WindContext context)
//    {
//        _windDbManager = new WindDBManager(context);
//    }

//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(StatusCodes.Status404NotFound)]
//    [HttpGet]
//    public ActionResult<IEnumerable<WindData>>
//        GetAll([FromQuery] int? vindhastighed, [FromQuery] string? vindretning)
//    {
//        IEnumerable<WindData> wind = _windDbManager.GetAll();
//        if (wind.Count() <= 0)
//        {
//            return NotFound();
//        }
//        else
//        {
//            return Ok(wind);
//        }
//    }
    
//    [ProducesResponseType(StatusCodes.Status201Created)]
//    [ProducesResponseType(StatusCodes.Status400BadRequest)]
//    [HttpPost]
//    public ActionResult<WindData> Add([FromBody] WindData newWind)
//    {
//        WindData wind = new WindData();
        
//        if (newWind.Vindretning == null || newWind.Vindhastighed <= 0) 
//        {
//            return BadRequest(newWind);
//        }
        
//        wind = _windDbManager.Add(newWind);
//        return Created("api/wind/" + wind.Id, wind);
//    }
//}