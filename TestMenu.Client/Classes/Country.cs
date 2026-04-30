using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TestMenu.Classes
{
    public class Country
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Country Name")]
        public string? countryName { get; set; }
    }
}
