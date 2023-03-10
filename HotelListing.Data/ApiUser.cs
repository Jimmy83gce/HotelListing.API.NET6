using Microsoft.AspNetCore.Identity;

namespace HotelListing.NET6.Data
{
    public class ApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
