using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaTask.Models
{
    public class Pizza
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(3)]
        public string ShortName { get; set; }
        [Required]
        public EPizzaStockStatus StockStatus { get; set; }
        [Required]
        public string Ingredients { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
