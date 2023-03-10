using System.ComponentModel.DataAnnotations;

namespace HotelListing.NET6.Models.Users
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Hasło limitowane pomiędzy {2} i {1} znaków", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
