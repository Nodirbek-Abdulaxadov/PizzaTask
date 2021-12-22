using PizzaTask.Models;
using System;
using System.Collections.Generic;

namespace PizzaTask.Services
{
    public interface IPizzaService
    {
        IEnumerable<Pizza> GetAllPizzas();
        Pizza GetById(Guid id);
        Pizza AddPizza(Pizza pizza);
        Pizza UpdatePizza(Pizza pizza);
        void DeletePizza(Guid id);
    }
}
