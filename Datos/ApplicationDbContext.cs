using Microsoft.EntityFrameworkCore;

namespace CursoEntityCore.Datos
{
  // Para que ApplicationDbContext herede de la clase para manejar las instancias de conexion a la base de datos, y de mas accesos
  // Se debe heredar, escribiendo :DbContext

  public class ApplicationDbContext:DbContext
  {
    // Crear el constructor
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones)
    {
    }

    // Se tienen que definir los modelos de las Entidades que se manaje en el Sistema.

  } // public class ApplicationDbContext:DbContext
}
