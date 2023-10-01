using Microsoft.AspNetCore.Mvc;
using SDA_WEB_APP_MVC.Models;

namespace SDA_WEB_APP_MVC.BusinessLayer.Iterfaces
{
    public interface IArtikullService
    {
        public Task<Artikull> GetByName([FromRoute] string name);
    }
}
