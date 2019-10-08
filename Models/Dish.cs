using System.ComponentModel.DataAnnotations;
using System;

namespace first_entity.Models
{
    public class Dish
    {
        //   The key attribute is used to mark the Model property being used as Primary key
        [Key]
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Chef { get; set; }
        public int Tastiness { get; set; }
        public int Calories { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}