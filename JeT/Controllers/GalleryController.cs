using JeT.Models;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web.Mvc;

namespace JeT.Controllers
{
    public class GalleryController : Controller
    {
        public ActionResult Index()
        {
            
            List<Photo> photos = new List<Photo>();

            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Content/img/gallery")); ;

            foreach (FileInfo file in dir.GetFiles())
            {
                photos.Add(
                     new Photo()
                     {
                        FilePath = file.Name
                    }
               );
            }
           
            return View(photos);
        }
    }
}