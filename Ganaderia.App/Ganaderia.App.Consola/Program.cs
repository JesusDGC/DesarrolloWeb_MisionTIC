using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {
        
        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            GetAllGanaderos();
        }

        private static void AddGanadero ()
        {
            var ganadero = new Ganadero
            {
                Nombres = "Claudia Ximena",
                Apellidos = "Gomez Arboleda",
                NumeroTelefono = "3159876543",
                Direccion = "Calle 10 # 59-12",
                Correo = "xicla@hotmail.com",
                Contrasena = "1234",
                Latitude = 4556,
                Longitud = 3445
            };

            _repoGanadero.AddGanadero(ganadero);

        }

        private static void GetAllGanaderos()
        {
            var ganaderos = _repoGanadero.GetAllGanaderos();
            //for (int i = 0; i < 10; i++)

            foreach(Ganadero item in ganaderos)
            {
                Console.WriteLine(item.Nombres);
            }
        }
    }
}
