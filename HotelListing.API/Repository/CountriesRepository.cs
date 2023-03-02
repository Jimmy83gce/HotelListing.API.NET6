using HotelListing.NET6.Contracts;
using HotelListing.NET6.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.NET6.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelListingDbContext context) 
            : base(context)
        {
            _context = context;
        }

        private readonly HotelListingDbContext _context;

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries
                                    .Include(q => q.Hotels)
                                    .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
