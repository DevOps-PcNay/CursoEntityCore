using CursoEntityCore.Models;
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
    // Se nombra igual como se llama en la clase, por convencion y es utilizado para las demas Etapas del patron de diseño
    // En este caso se llama "Categoria"
    public DbSet<Categoria>Categorias { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Articulo> Articulo { get; set; }

    public DbSet<DetalleUsuario> DetalleUsuario { get; set; }
  } // public class ApplicationDbContext:DbContext
}
