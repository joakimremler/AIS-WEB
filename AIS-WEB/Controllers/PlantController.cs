using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIS_WEB.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AIS_WEB.Controllers
{
    public class PlantController : Controller
    {
        //private List<PlantViewModel> plants;
        //private PlantViewModel plant;

        // GET: Plant
        public ActionResult Index()
        {
            //Get all plants from API
            //client.BaseAddress = new Uri("http://localhost:61347/");
            

            return View();
        }

        //localhost:52844/Plant/PlantsJs
        public ActionResult PlantsJS ()
        {
            
            return View();
       
        }

        public ActionResult PlantOrNot()
        {
            return View();

        }

        public ActionResult GetPlant()
        {
            PlantViewModel plant = new PlantViewModel();
            //System.Diagnostics.Debug.WriteLine("start");
            //System.Diagnostics.Debug.WriteLine(Json(plant.getPlantAPI(), JsonRequestBehavior.AllowGet));
            return Json(plant.getPlantAPI(), JsonRequestBehavior.AllowGet);

        } 

        [HttpPost]
        public  ActionResult Create(PlantViewModel plant)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(PlantViewModel plant)
        {
            //edit api
            return View();
        }
    }
}