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
using System.Text;

namespace AIS_WEB.Controllers
{
    public class PlantController : Controller
    {

        public ActionResult Index()
        {
            PlantViewModel plant = new PlantViewModel();
            var result = plant.getPlantAPI();
            return View(result);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PlantViewModel plant)
        {
            using (HttpClient client = new HttpClient())
            {
                //Connect to server
                client.BaseAddress = new Uri("http://localhost:61347/");

                //Clears old data???
                client.DefaultRequestHeaders.Accept.Clear();

                PlantViewModel newPlant = new PlantViewModel();

                newPlant.Name = plant.Name;
                newPlant.SoilMoistureMin = plant.SoilMoistureMin;
                newPlant.SoilMoistureMax = plant.SoilMoistureMax;
                newPlant.SoilMoistureNow = plant.SoilMoistureNow;
                newPlant.Category = plant.Category;
                newPlant.SunlightMin = plant.SunlightMin;
                newPlant.SunlightMax = plant.SunlightMax;
                newPlant.SunlightNow = plant.SunlightNow;
                newPlant.ID_Type = plant.ID_Type;
                newPlant.StartDate = plant.StartDate;
                newPlant.Updated = plant.Updated;
                newPlant.Pic_url = plant.Pic_url;

                var response = client.PostAsync("http://localhost:61347/api/Plant/", new StringContent(
                Newtonsoft.Json.JsonConvert.SerializeObject(newPlant), Encoding.UTF8, "application/json")).Result;
            }
            return RedirectToAction("Index");
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
            using (HttpClient client = new HttpClient())
            {
                //Connect to server
                client.BaseAddress = new Uri("http://localhost:61347/");

                //Clears old data???
                client.DefaultRequestHeaders.Accept.Clear();

                PlantViewModel newPlant = new PlantViewModel();
                newPlant.Name = plant.Name;
                newPlant.SoilMoistureMin = plant.SoilMoistureMin;
                newPlant.SoilMoistureMax = plant.SoilMoistureMax;
                newPlant.SoilMoistureNow = plant.SoilMoistureNow;
                newPlant.Category = plant.Category;
                newPlant.SunlightMin = plant.SunlightMin;
                newPlant.SunlightMax = plant.SunlightMax;
                newPlant.SunlightNow = plant.SunlightNow;
                newPlant.ID_Type = plant.ID_Type;
                newPlant.StartDate = plant.StartDate;
                newPlant.Updated = plant.Updated;
                newPlant.Pic_url = plant.Pic_url;

                //Update api
                var response = client.PutAsync("http://localhost:61347/api/Plant/" + plant.ID, new StringContent(
                Newtonsoft.Json.JsonConvert.SerializeObject(newPlant), Encoding.UTF8, "application/json")).Result;
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            PlantViewModel plant = new PlantViewModel();
            var result = plant.getPlant(id);
            return View(result);
        }

        [HttpPost]
        public ActionResult Delete(PlantViewModel plant)
        {
            using (HttpClient client = new HttpClient())
            {
                //Connect to server
                client.BaseAddress = new Uri("http://localhost:61347/");

                //Clears old data???
                client.DefaultRequestHeaders.Accept.Clear();

                //delete api based on id
                var response = client.DeleteAsync("http://localhost:61347/api/Plant/" + plant.ID).Result;
            }
            return RedirectToAction("Index");
        }
    }
}
