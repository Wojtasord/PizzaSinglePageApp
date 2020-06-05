using System.Collections.Generic;
using System.Linq;

namespace PizzaSinglePageApp.Shared
{
    public class Menu
    {
        
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public Pizza GetPizza(int id) => Pizzas.SingleOrDefault(p => p.Id == id);
    }
}