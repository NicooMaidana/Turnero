using System.ComponentModel.DataAnnotations;

namespace Turnero.Models;

public class Localidad
{
    [Key]
    public int LocalidadID { get; set; }
    public required string NombreLocalidad { get; set; }
    public int ProvinciaID { get; set; }
    public virtual required Provincia Provincias { get; set; }

}


