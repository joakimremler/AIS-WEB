using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIS_WEB.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


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
            PlantViewModel plant = new PlantViewModel();
            var result = plant.getPlantAPI();
            return View(result);
        }

        public ActionResult GetPlant()
        {
            return View();

        }

        [HttpPost]
        public  ActionResult Create(PlantViewModel plant)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            PlantViewModel plant = new PlantViewModel();
            var result = plant.getPlant(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Edit(PlantViewModel plant)
        {
            //edit api
            return View();
        }
    }
}