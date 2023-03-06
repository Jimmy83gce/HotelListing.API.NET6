using AutoMapper;
using HotelListing.NET6.Contracts;
using HotelListing.NET6.Data;
using HotelListing.NET6.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.NET6.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        public UserManager<ApiUser> _userManager;

        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            bool isValidUser = false;
            try
            {
                //var user = await _userManager.FindByEmailAsync(loginDto.Email);
                //isValidUser = await _userManager.CheckPasswordAsync(user, loginDto.Password);

                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if (user is null)
                {
                    return default;
                }

                bool isValidCredentials = await _userManager.CheckPasswordAsync(user, loginDto.Password);

                if (!isValidCredentials)
                {
                    return default;
                }
            }
            catch (Exception ex) { }
            return isValidUser;

            
        }

        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email;

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }
    }
}
