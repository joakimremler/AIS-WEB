using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace AIS_WEB.Models
{
    public class PlantViewModel
    {
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
  

        public Object getPlantAPI()
        {
            string url = "http://localhost:61347/api/Plant";
            var client = new System.Net.WebClient();
            //download API as a string
            var content = client.DownloadString(url);
            var sterializer = new JavaScriptSerializer();
            //read from string and change it to json
            var jsonContent = sterializer.Deserialize<Object>(content);
            //System.Diagnostics.Debug.WriteLine("start2");
            //System.Diagnostics.Debug.WriteLine(jsonContent);
            return jsonContent;
        }
  
    }
}