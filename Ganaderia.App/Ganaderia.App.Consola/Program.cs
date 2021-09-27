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
            //Console.WriteLine("Hello World!");
            //AddGanadero();
            //GetAllGanaderos();
            //UpdateGanadero();
            //DeleteGanadero(2);
            GetGanadero(1);
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

            Console.WriteLine("Fue adicionado el ganadero " + ganadero.Nombres + " " + ganadero.Apellidos);

        }

        /// <summary>
        /// Este método permite obtener la información de todos los ganaderos registrados en la base de datos.
        /// </summary>
        private static void GetAllGanaderos()
        {
            var ganaderos = _repoGanadero.GetAllGanaderos();

            Console.WriteLine("Listado de Ganaderos:");

            foreach(Ganadero item in ganaderos)
            {
                Console.WriteLine(item.Nombres + " " + item.Apellidos);
            }
        }

        private static void UpdateGanadero()
        {
            var ganadero = new Ganadero
            {
                Id = 2,
                Nombres = "Claudia X.",
                Apellidos = "Gomez A.",
                NumeroTelefono = "3159876543",
                Direccion = "Calle 10 # 59-12",
                Correo = "xicla@hotmail.com",
                Contrasena = "1234",
                Latitude = 4556,
                Longitud = 3445
            };

            _repoGanadero.UpdateGanadero(ganadero);

            Console.WriteLine("Fue actualizado el ganadero " + ganadero.Nombres + " " + ganadero.Apellidos);
        }

        private static void DeleteGanadero(int idGanadero)
        {
            _repoGanadero.DeleteGanadero(idGanadero);
            Console.WriteLine("Fue borrado el ganadero " + idGanadero);
        } 

        private static void GetGanadero(int idGanadero)
        {
            var ganadero = _repoGanadero.GetGanadero(idGanadero);
            Console.WriteLine("El ganadero seleccionado es " + ganadero.Nombres + " " + ganadero.Apellidos);
        }
    }
}
