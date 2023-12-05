using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Cinepolis_v2.Models;
using Newtonsoft.Json;

namespace Cinepolis_v2.Controllers {
    public class API {

        private readonly string apiBaseUri = "http://ec2-3-137-184-32.us-east-2.compute.amazonaws.com/PM2GRUPO3/public/api/";
        private readonly JsonSerializerSettings jsonSettings;
        private readonly HttpClient _client;
        public string Errores {  get; set; }        


        public API() {
            _client = new HttpClient();

            jsonSettings = new JsonSerializerSettings() { 
                Formatting = Formatting.Indented,
            };
        }







        public async Task<List<T>> PostRequest<T>(T modelo, string endpoint) {
            Uri uri = new Uri(apiBaseUri + endpoint);
            List<T> Items = new List<T>();
            Errores = string.Empty;
            
            try {
                string jsonString = JsonConvert.SerializeObject(modelo, jsonSettings);
                StringContent data = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(uri, data);
                if (response.IsSuccessStatusCode) {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<T>>(content);
                
                } else {
                    throw new Exception("status code: " + response.StatusCode.ToString());
                }

            } catch (Exception ex) {
                Errores = ex.Message;
                Console.WriteLine("####################################\n" + ex.Message + "\n##############################");                
            }

            return Items;
        }




        



        





    }
}
