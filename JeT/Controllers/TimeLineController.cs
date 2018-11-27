using JeT.Models;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Web.Mvc;

namespace JeT.Controllers
{
    public class TimeLineController : Controller
    {
        public ActionResult Index()
        {
            
            List<Card> cards = new List<Card>();

            using (StreamReader r = new StreamReader(Server.MapPath("~/Content/cards.json")))
            {
                string json = r.ReadToEnd();
                cards = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Card>>(json);
            }            

            return View(cards);
        }
    }
}