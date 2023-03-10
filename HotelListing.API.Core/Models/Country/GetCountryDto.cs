using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.NET6.Models.Country
{
    public class GetCountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

    }
}
