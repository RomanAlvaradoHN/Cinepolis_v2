using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cinepolis_v2.Controllers;
using Cinepolis_v2.Models;


namespace Cinepolis_v2.Controllers {
    public class HomeController {

        public readonly API api;



        public HomeController() {
            api = new API();
        }


        public async Task<List<string>> ListaDeCines() {
            List<Cine> lista = await api.PostRequest(new Cine(), "lista-cines");
            List<string> cines = new List<string>();

            if (string.IsNullOrEmpty(api.Errores)) {
                if (lista.Count > 0) {
                    lista.ForEach(cine => {
                        cines.Add(cine.Ubicacion);
                    });
                }
            }

            return cines;
        }



        public async Task<List<Pelicula>> ListaDePeliculas() {
            List<Pelicula> lista = await api.PostRequest(new Pelicula(), "lista-peliculas");
            return lista;
        }


    }
}
