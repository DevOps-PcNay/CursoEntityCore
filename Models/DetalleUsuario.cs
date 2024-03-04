using System.ComponentModel.DataAnnotations;

namespace CursoEntityCore.Models
{
  public class DetalleUsuario
  {
    [Key]
    public int DetalleUsuario_Id { get; set; }
    public string Cedula { get; set; }
    public string Deporte { get; set; }
    public string Mascota {  get; set; }

    // Se instancia el Objeto "Usuario"
    public Usuario Usuario {  get; set; } 

  }
}
