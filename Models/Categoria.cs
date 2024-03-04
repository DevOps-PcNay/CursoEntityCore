using System.ComponentModel.DataAnnotations;

namespace CursoEntityCore.Models
{
  public class Categoria
  {
    [Key]
    public int Categoria_Id { get; set; }
    [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[NULL]")]
    public string Nombre { get; set; }

    // Estableciendo Relacion de Muchos a uno, se pasa a una lista la Categoria(Puede tener muchos Articulos)
    public List<Articulo> Articulo { get; set; }
  }
}
