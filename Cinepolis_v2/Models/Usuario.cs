using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepolis_v2.Models {
    public class Usuario {
        private List<string> invalidData = new List<string>();
        private string correo;
        private string contrasenia;

        public Usuario() { }


        public Usuario(string correo, string contrasenia) {
            this.Correo = correo;
            this.Contrasenia = contrasenia;
        }

        public Usuario(string errorMessage) {
            this.invalidData.Add(errorMessage);
        }
        
        public List<string> GetDatosInvalidos() {
            return this.invalidData;
        }







        [JsonIgnore]
        [JsonProperty("id")]
        public int Id { get; set; }


        [JsonProperty("correo")]
        public string Correo {
            get { return this.correo; }
            set {
                if(!string.IsNullOrEmpty(value)) {
                    this.correo = value;
                } else {
                    this.invalidData.Add("correo no valido.");
                }
            }
        }

        [JsonIgnore]
        [JsonProperty("nombre")]
        public string Nombre {  get; set; }


        
        [JsonProperty("contrasenia")]
        public string Contrasenia {
            get { return this.contrasenia; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    this.contrasenia = value;
                } else {
                    this.invalidData.Add("contraseña no valida");
                }
            }
        }


        [JsonIgnore]
        [JsonProperty("estado")]
        public string Estado { get; set; }

        [JsonIgnore]
        [JsonProperty("fecha_creacion")]
        public DateTime FechaCreacion { get; set; }

        [JsonIgnore]
        [JsonProperty("rol")]
        public string Rol {  get; set; }
    }
}
