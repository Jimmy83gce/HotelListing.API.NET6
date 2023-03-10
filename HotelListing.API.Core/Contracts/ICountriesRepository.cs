using HotelListing.NET6.Data;
using HotelListing.NET6.Models.Country;

namespace HotelListing.NET6.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
