using HotelListing.NET6.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.NET6.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);

        Task<AuthResponseDto> Login(LoginDto loginDto);

        Task<string> CreateRefershToken();

        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
