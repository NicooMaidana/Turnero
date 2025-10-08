using System.ComponentModel.DataAnnotations;

namespace Turnero.Models;

public class Provincia
{
    [Key]
    public int ProvinciaID { get; set; }
    public required string NombreProvincia { get; set; }
    public virtual required ICollection<Localidad> Localidades { get; set; }
}