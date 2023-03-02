using HotelListing.NET6.Data;

namespace HotelListing.NET6.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
