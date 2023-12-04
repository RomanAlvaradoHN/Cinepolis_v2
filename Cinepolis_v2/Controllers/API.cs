using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Cinepolis_v2.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Cinepolis_v2.Controllers {
    public class API {

        private string apiBaseUri = "http://ec2-3-147-27-96.us-east-2.compute.amazonaws.com/PM2GRUPO3/public/api/";
        private HttpClient _client;
        private List<Usuario> Items;
        private JsonSerializerSettings jsonSettings;


        public API() {
            _client = new HttpClient();

            jsonSettings = new JsonSerializerSettings() { 
                Formatting = Formatting.Indented,
            };
        }




        public async Task<List<Usuario>> ValidarUsuario(Usuario u) {
            Items = new List<Usuario>();
            Uri uri = new Uri(apiBaseUri + "validar-usuarios");
            try {
                string jsonString = JsonConvert.SerializeObject(u, jsonSettings);
                StringContent data = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(uri, data);
                if (response.IsSuccessStatusCode) {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Usuario>>(content);
                
                } else {
                    Items.Add(new Usuario("Status Code no exitoso"));
                }

            } catch (Exception ex) {
                Console.WriteLine("#################################\n" + ex.ToString() + "\n#################################");
                Items.Add(new Usuario(ex.Message));
            }

            return Items;
        }



        





    }
}
