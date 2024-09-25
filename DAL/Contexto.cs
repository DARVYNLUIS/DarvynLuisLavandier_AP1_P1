using Microsoft.EntityFrameworkCore;
using DarvynLuisLavandier_AP1_P1.Models;
namespace DarvynLuisLavandier_AP1_P1.DAL
{
    public class Contexto : DbContext
    {
        DbSet<Registros> Registros { get; set; }
        public Contexto(DbContextOptions<Contexto>options) 
            : base(options)
        
        { }
    }
}
