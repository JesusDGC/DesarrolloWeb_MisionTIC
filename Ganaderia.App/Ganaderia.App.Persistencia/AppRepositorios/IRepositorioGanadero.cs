using Ganaderia.App.Dominio;
using System.Collections.Generic;


namespace Ganaderia.App.Persistencia
{
    /// <summary>
    /// Interfaz con los métodos para el CRUD de la entidad Ganadero
    /// </summary>
    public interface IRepositorioGanadero
    {
        Ganadero AddGanadero(Ganadero ganadero);

        IEnumerable<Ganadero> GetAllGanaderos();

        Ganadero UpdateGanadero(Ganadero ganadero);

        void DeleteGanadero(int idGanadero);

        Ganadero GetGanadero(int idGanadero);
    }
}