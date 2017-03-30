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

            System.Diagnostics.Debug.WriteLine("testing");
            System.Diagnostics.Debug.WriteLine(result);

            return View(result);
            //return View();

        }

        public ActionResult GetPlant()
        {/*
            PlantViewModel plant = new PlantViewModel();
            var result = plant.getPlantAPI();

            System.Diagnostics.Debug.WriteLine("testing");
            System.Diagnostics.Debug.WriteLine(result);
            */
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


            string url = "http://localhost:61347/api/Plant/" + id;
            System.Diagnostics.Debug.WriteLine("start");
            System.Diagnostics.Debug.WriteLine(url);
            /*
            var client = new System.Net.WebClient();
            //download API as a string
            var content = client.DownloadString(url);
            var sterializer = new JavaScriptSerializer();
            //read from string and change it to json
            var jsonContent = sterializer.Deserialize<Object>(content);
            //System.Diagnostics.Debug.WriteLine("start2");
            //System.Diagnostics.Debug.WriteLine(jsonContent);
            return View(jsonContent);*/
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