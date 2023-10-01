using Microsoft.AspNetCore.Mvc;
using SDA_WEB_APP_MVC.DataLayer;

namespace SDA_WEB_APP_MVC.Controllers
{
    public class ArtikullController : Controller
    {
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

                return View(artikujt);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
