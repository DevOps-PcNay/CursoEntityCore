using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntityCore.Models
{
  [Table("Tbl_Articulo")] // Cambiar el nombre de la tabla.
  public class Articulo
  {
    [Key]
    public int Articulo_Id { get; set; }
    [Column("Titulo")]
    [Required]
    [MaxLength(20)]
    public string TituloArticulo { get; set;}
    [StringLength(45,ErrorMessage = "Longuitud Maxima")]
    public string Descripcion { get; set; }
    [DataType(DataType.Date)]
    public DateTime Fecha {  get; set; }

  }
}
