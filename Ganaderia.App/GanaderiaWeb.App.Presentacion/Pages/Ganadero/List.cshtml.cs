using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GanaderiaWeb.App.Dominio;

namespace GanaderiaWeb.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        public List<Ganadero> ListaGanaderos {get; set;}

        public void OnGet()
        {
            Ganadero ganadero;
            ListaGanaderos = new List<Ganadero>();

            ganadero = new Ganadero {
                Nombres = "Mario",
                Apellidos = "Herrera",
                NumeroTelefono = "3117778899",
                Direccion = "Cra. 13 No. 7-89",
                Correo = "m.herrera@gmail.com",
                Contrasena = "123abc",
                Latitud = 7.455F,
                Longitud = 5.533F
            };
            ListaGanaderos.Add(ganadero);

            ganadero = new Ganadero {
                Nombres = "Sandra",
                Apellidos = "Burbano",
                NumeroTelefono = "3149995566",
                Direccion = "Cra. 13 No. 7-89",
                Correo = "sandra.b@gmail.com",
                Contrasena = "123abc",
                Latitud = 7.455F,
                Longitud = 5.533F
            };
            ListaGanaderos.Add(ganadero);

            ganadero = new Ganadero {
                Nombres = "Camilo",
                Apellidos = "Gutierrez",
                NumeroTelefono = "3149995566",
                Direccion = "Cra. 13 No. 7-89",
                Correo = "camilo.g@gmail.com",
                Contrasena = "123abc",
                Latitud = 7.455F,
                Longitud = 5.533F
            };
            ListaGanaderos.Add(ganadero);
        }
    }
}
