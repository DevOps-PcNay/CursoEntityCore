using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntityCore.Models
{
  public class ArticuloEtiqueta
  {
    // Se copian los dos atributos de Id de la tabla "Articulo" y "Etiqueta"
    // No se puede agregar la Data Annotation "[key]".
    // Por lo que se tiene que agregar el Fluen API.
    [ForeignKey("Articulo")]
    public int Articulo_Id { get; set; }
    [ForeignKey("Etiqueta")]
    public int Etiqueta_Id { get; set;}

    // Instanciar los dos objetos de "Articulo" y "Etiqueta"
    public Articulo Articulo { get; set; }
    public Etiqueta Etiqueta { get; set; }

  }
}
