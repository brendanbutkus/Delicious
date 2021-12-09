using System;
using System.ComponentModel.DataAnnotations;

namespace Delicious.Models
{
    public class Dishes
    {
        [Key]
        public int DishId {get;set;}

        [Required(ErrorMessage ="Name is required")]
        [MinLength(2, ErrorMessage ="Name must be at least two characters")]
        public string Name {get;set;}

        [Required(ErrorMessage="Chef is required")]
        public string Chef {get;set;}

        [Required(ErrorMessage ="Tastiness is required")]
        public int Tastiness {get;set;}

        [Required(ErrorMessage ="Calories is required")]
        [Range(1, 10000, ErrorMessage ="Calories must be more than 1")]
        public int Calories {get;set;}

        [Required(ErrorMessage ="Description is required")]
        [MinLength(2, ErrorMessage ="Description must be at least two characters")]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        


    }
}