using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace PizzaStore.Models
{
    
    public class Pizza
    {
        [Key]
        public int IdEhod { get; set; }
        public string? NomEhod { get; set; }
        public string? DescriptionEhod { get; set; }

    
    }

    class PizzaDb : DbContext
    {
        public PizzaDb(DbContextOptions options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; } = null!;
    }
}