using Microsoft.AspNetCore.Mvc;
using SDA_WEB_APP_MVC.BusinessLayer.Iterfaces;
using SDA_WEB_APP_MVC.DataLayer;

namespace SDA_WEB_APP_MVC.Controllers
{
    public class ArtikullController : Controller
    {
        private readonly IArtikullService _artikullService;
        public ArtikullController(IArtikullService artikullService) 
        {
            _artikullService = artikullService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Artikujt()
        {
            try
            {
                var artikujt = StaticData.Artikujt.ToList();

                if (artikujt.Count == 0)
                    return new EmptyResult();

                return View("TableArtikujt", artikujt);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetByName([FromQuery] string name)
        {
            try
            {
                var result = await _artikullService.GetByName(name);

                if (result == null)
                    return new EmptyResult();

                return View("Details", result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet]
        public async Task<ActionResult> FilterByDescription([FromQuery] string des)
        {
            try
            {
                var artikujt = StaticData.Artikujt.ToList()
                   .Where(p => p.Description.Contains(des))
                   .ToList();

                return View("TableArtikujt", artikujt);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        [HttpGet]
        public async Task<ActionResult> FilterByDate([FromQuery] DateTime created)
        {
            try
            {
                var artikujt = StaticData.Artikujt.ToList()
                    .Where(p => p.DateCreated < DateTime.Now)
                    .ToList();

                return View("artikujt", artikujt);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetByID([FromRoute] int id)
        {
            try
            {
                var artikulli = StaticData.Artikujt.ToList()
                    .Where(p => p.ID == id)
                    .FirstOrDefault();

                if (artikulli == null)
                    return new EmptyResult();

                return View("Details",artikulli);
            }
            catch(Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
