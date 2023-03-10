using AutoMapper;
using AutoMapper.QueryableExtensions;
using HotelListing.NET6.Contracts;
using HotelListing.NET6.Data;
using HotelListing.NET6.Exceptions;
using HotelListing.NET6.Models.Country;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.NET6.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelListingDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        private readonly HotelListingDbContext _context;
        private readonly IMapper _mapper;

        public async Task<CountryDto> GetDetails(int id)
        {
            var country = await _context.Countries
                                .Include(q => q.Hotels)
                                .ProjectTo<CountryDto>(_mapper.ConfigurationProvider)
                                .FirstOrDefaultAsync(q => q.Id == id);

            if(country == null)
            {
                throw new NotFoundException(nameof(GetDetails), id);
            }

            return country;
        }
    }
}
