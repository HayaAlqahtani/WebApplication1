using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AddCustomer
    {
        [Required]
        public string Name { get; set; }


        [EmailAddress]
        public string Email { get; set; }

    }
}
