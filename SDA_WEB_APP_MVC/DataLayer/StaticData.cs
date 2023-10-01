using SDA_WEB_APP_MVC.Models;

namespace SDA_WEB_APP_MVC.DataLayer
{
    public static class StaticData
    {
        public static List<Artikull> Artikujt = new List<Artikull>()
        {
            new Artikull()
            {
                ID = 1,
                PhotoUrl = "C:\\Users\\User\\Downloads\\photo-1523275335684-37898b6baf30.jfif",
                DateCreated = new DateTime(2021,8,14),
                Name = "Laptop PC",
                Description = "Lenovo Laptop"
            },
             new Artikull()
            {
                ID = 2,
                PhotoUrl = "C:\\Users\\User\\Downloads\\photo-1523275335684-37898b6baf30.jfif",
                DateCreated = new DateTime(2021,8,14),
                Name = "Desktop PC",
                Description = "Agic Desktop"
            }
        };
    }
}
