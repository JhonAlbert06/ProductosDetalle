using Microsoft.EntityFrameworkCore;
using Ejemplo_Clase1522022.Entidades;

namespace Ejemplo_Clase1522022.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Productos> Productos { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DATA/Productos.db");            
        }
    }
}