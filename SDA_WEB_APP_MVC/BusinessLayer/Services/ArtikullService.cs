using Microsoft.AspNetCore.Mvc;
using SDA_WEB_APP_MVC.BusinessLayer.Iterfaces;
using SDA_WEB_APP_MVC.DataLayer;
using SDA_WEB_APP_MVC.Models;

namespace SDA_WEB_APP_MVC.BusinessLayer.Services
{
    public class ArtikullService : IArtikullService
    {
        public ArtikullService() { }

       public async Task<Artikull> GetByName([FromRoute] string name)
        {
            try
            {
                var artikulli = StaticData.Artikujt.ToList()
                    .Where(p => p.Name.Trim() == name.Trim())
                    .FirstOrDefault();

                return artikulli;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
