using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinepolis_v2.Models;
using Cinepolis_v2.Controllers;


namespace Cinepolis_v2.Controllers {
    public class LoginController {

        private readonly API api;




        public LoginController() {
            this.api = new API();
        }


        
        public async Task<string> ValidarUsuario(Usuario u) {
           List<Usuario> respuesta = await api.PostRequest(u, "validar-usuario");

            if (string.IsNullOrEmpty(api.Errores)) {
                if(respuesta.Count == 1) {
                    return "verificado";

                } else { 
                    return "denegado";
                }


            } else {
                return api.Errores;
            }
        }

    }
}
