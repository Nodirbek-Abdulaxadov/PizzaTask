using PizzaTask.DataLayer;
using PizzaTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaTask.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly ApplicationDbContext _dbContext;

        public PizzaService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Pizza AddPizza(Pizza pizza)
        {
            _dbContext.Pizzas.Add(pizza);
            _dbContext.SaveChanges();

            return pizza;
        }

        public void DeletePizza(Guid id)
        {
            Pizza pizza = _dbContext.Pizzas.FirstOrDefault(p => p.Id == id);
            _dbContext.Remove(pizza);
        }

        public IEnumerable<Pizza> GetAllPizzas() => _dbContext.Pizzas.ToList();

        public Pizza GetById(Guid id) => _dbContext.Pizzas.FirstOrDefault(p => p.Id == id);

        public Pizza UpdatePizza(Pizza pizza)
        {
            _dbContext.Pizzas.Update(pizza);
            _dbContext.SaveChanges();

            return pizza;
        }
    }
}
