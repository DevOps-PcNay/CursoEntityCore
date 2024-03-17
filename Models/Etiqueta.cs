using System.ComponentModel.DataAnnotations;

namespace CursoEntityCore.Models
{
  public class Etiqueta
  {
    [Key]
    public int Etiqueta_Id { get; set; }
    public string Titulo { get; set; }
    // Para que solo guarde la fecha.
    [DataType(DataType.Date)]
    public DateTime Fecha { get; set; }

    // Para relacion de Muchos a Muchos 
    public ICollection<ArticuloEtiqueta> ArticulEtiqueta { get; set; }


  }
}
