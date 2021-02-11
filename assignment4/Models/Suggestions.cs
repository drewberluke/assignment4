using System;
using System.ComponentModel.DataAnnotations;

//suggestion model. validates and shows custom messages for requried fields and phone number validation
namespace assignment4.Models
{
    public class Suggestions
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a restaurant name")]
        public string RecName { get; set; }
        public string RecFav { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$", ErrorMessage = "Please use the correct phone number format")]
        public string RecPhone { get; set; }
    }
}
