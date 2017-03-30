﻿using System;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult Create(PlantViewModel plant)
        {
            System.Diagnostics.Debug.WriteLine("Start 1");
            using (HttpClient client = new HttpClient())
            {
                //Connect to server
                client.BaseAddress = new Uri("http://localhost:61347/");

                //Clears old data???
                client.DefaultRequestHeaders.Accept.Clear();
                System.Diagnostics.Debug.WriteLine("Start 2");
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

                System.Diagnostics.Debug.WriteLine("plant name: " + plant.Name);
                System.Diagnostics.Debug.WriteLine("newPlant name: " + newPlant.Name);
                System.Diagnostics.Debug.WriteLine("Start 3");
                var response = client.PostAsync("http://localhost:61347/api/Plant/", new StringContent(
                new JavaScriptSerializer().Serialize(newPlant), Encoding.UTF8, "application/json")).Result;


            }
            //edit api
            System.Diagnostics.Debug.WriteLine("Start 4");

            return View();

            /*
            var client = new HttpClient();

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
            string url = String.Format("http://localhost:61347/api/Plant/{0}", plant.ID);

            //update api
            var response = client.PostAsync("api/Plant", new StringContent(
             new JavaScriptSerializer().Serialize(newPlant), Encoding.UTF8, "application/json")).Result;
             */




            //client.PostAsJsonAsync("api/Plant", newPlant).Result;

            //await client.PutAsJsonAsync(url, newPlant);


            /*
            using (var client2 = new HttpClient())
                {
                    var response = client2.PostAsJsonAsync("api/Plant", newPlant).Result;

                }
            */


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
            System.Diagnostics.Debug.WriteLine("Start 1");
            using (HttpClient client = new HttpClient())
            {
                //Connect to server
                client.BaseAddress = new Uri("http://localhost:61347/");

                //Clears old data???
                client.DefaultRequestHeaders.Accept.Clear();
                System.Diagnostics.Debug.WriteLine("Start 2");
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

                System.Diagnostics.Debug.WriteLine("plant name: " + plant.Name);
                System.Diagnostics.Debug.WriteLine("newPlant name: " + newPlant.Name);
                //string url = String.Format("http://localhost:61347/api/Plant/{0}", plant.ID);
                System.Diagnostics.Debug.WriteLine("Start 3");
                //var response = client.PostAsync("http://localhost:61347/api/Plant/" + plant.ID, new StringContent(
                var response = client.PostAsync("http://localhost:61347/api/Plant/", new StringContent(
                new JavaScriptSerializer().Serialize(newPlant), Encoding.UTF8, "application/json")).Result;


            }
            //edit api
            System.Diagnostics.Debug.WriteLine("Start 4");
            return View(plant);
        }
    }
}