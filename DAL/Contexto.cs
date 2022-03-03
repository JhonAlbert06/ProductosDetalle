using Microsoft.EntityFrameworkCore;
using Productos_Detalle.Entidades;

namespace Productos_Detalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; } 
        public Contexto(DbContextOptions<Contexto> options) : base(options){}
    }
}