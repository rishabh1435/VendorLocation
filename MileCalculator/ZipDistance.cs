using Google.Apis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace MileCalculator
{
    public class ZipDistance
    {

   
        public async Task<string> GetDistance(string fromzip, string tozip)
        {
           string ApiBaseUrl = "https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&";
         
            string _apiKey = "AIzaSyCHWZXFKpqInWGRR6cq7fLKoEIq4Yk6RD0";

            using (HttpClient client = new HttpClient())
            {
                string requestUrl = ApiBaseUrl+"origins="+fromzip+"&destinations="+tozip+"&key="+_apiKey+"";
                HttpResponseMessage response = await client.GetAsync(requestUrl);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                int index1 = jsonResponse.IndexOf("text");
                int index2 = jsonResponse.IndexOf("mi");
                string substringpart = jsonResponse.Substring(index1+7, index2-index1-4);
                return substringpart;

            }
        }


    }
}
