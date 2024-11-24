
using System.ComponentModel.DataAnnotations;

public class InquietudesContacto
{
    [Key]
    public int id_inquietud { get; set; }
    public required string nombre { get; set; }
    public required string email { get; set; }

    public required string titulo { get; set; }
    public required string mensaje { get; set; }

}