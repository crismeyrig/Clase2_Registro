
using System.ComponentModel.DataAnnotations;
public class Actores {

    [Key]
    public int ActorId  {get; set;}   

    public string Nombres { get; set; }

    public decimal SalarioAnual { get; set; }

    public string Direccion { get; set; }

    public string Telefono { get; set; }

}