using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntityCore.Models
{
  public class Usuario
  {
    public int Id { get; set; }
    [Required(ErrorMessage ="Nombre Obligatorio")]
    public string Nombre { get; set; }
    // [RegularExpression(@"^[\w-\._\*%]*@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Por Favor ingrese un Email Correcto !")]    
    [EmailAddress(ErrorMessage ="Ingrese Email Correcto !")]
    public string Email { get; set; }
    [Display(Name = "Direccion Usuario")]
    public string Direccion { get; set; }
    [Range(0.1,5.0)]
    public double Calificacion {  get; set; }
    [NotMapped]
    public int Edad {  get; set; }
    [ForeignKey("DetalleUsuario")]
    public int DetalleUsuario_Id { get; set; }
    // Instanciando el Objeto "DetalleUsuario"
    public DetalleUsuario DetalleUsuario { get; set; }

  }
}
