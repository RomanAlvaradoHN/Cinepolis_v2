using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinepolis_v2.Models {
    public class Pelicula {

        public Pelicula() { }


        public int Id { get; set; }
        public string Titulo {  get; set; }
        public int Duracion { get; set; }
        public string Sinopsis {  get; set; }
        public string Imagen {  get; set; }

        public string DuracionMinutos {
            get { return string.Concat(Duracion.ToString(), " Minutos"); }
        }
    }
}
