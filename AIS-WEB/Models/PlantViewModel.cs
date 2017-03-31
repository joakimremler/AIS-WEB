using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace AIS_WEB.Models
{
    public class PlantViewModel
    {
        private List<PlantViewModel> plants;
        private PlantViewModel plantitem;
        public long ID { get; set; }
      public string Name { get; set; }
      public int SoilMoistureMin { get; set; }
      public int SoilMoistureMax { get; set; }
      public int SoilMoistureNow { get; set; }
      public string Category { get; set; }
      public int SunlightMin { get; set; }
      public int SunlightMax { get; set; }
      public int SunlightNow { get; set; }
      public int ID_Type { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime Updated { get; set; }
      public string Pic_url { get; set; }


        public List<PlantViewModel> getPlantAPI()
        {
        string url = "http://localhost:61347/api/Plant";
            var client = new System.Net.WebClient();
            //download API as a string
            var content = client.DownloadString(url);
            plants = JsonConvert.DeserializeObject<List<PlantViewModel>>(content).ToList();

            return plants;
        }

        public PlantViewModel getPlant(string id)
        {
            string url = "http://localhost:61347/api/Plant/" + id;
            var client = new System.Net.WebClient();
            //download API as a string
            var content = client.DownloadString(url);
            plantitem = JsonConvert.DeserializeObject<PlantViewModel>(content);

            return plantitem;
        }

    }
}