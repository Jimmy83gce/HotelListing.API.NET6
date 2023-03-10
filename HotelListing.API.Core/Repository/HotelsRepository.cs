using AutoMapper;
using HotelListing.NET6.Contracts;
using HotelListing.NET6.Data;

namespace HotelListing.NET6.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}
