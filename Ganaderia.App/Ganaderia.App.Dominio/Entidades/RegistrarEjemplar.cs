namespace Ganaderia.App.Dominio
{
    public class RegistrarEjemplar : Ganadero

    {
        public int IdLote { get; set; }
        public int IdEjemplar { get; set; }
        public string FechaNacimiento { get; set; }
        public string Raza{ get; set; }
     }
}