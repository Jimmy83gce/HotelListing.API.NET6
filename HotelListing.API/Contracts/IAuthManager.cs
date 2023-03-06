using HotelListing.NET6.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.NET6.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);

        Task<bool> Login(LoginDto loginDto);
    }
}
