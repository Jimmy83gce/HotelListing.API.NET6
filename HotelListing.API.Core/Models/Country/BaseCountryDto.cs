namespace HotelListing.NET6.Models.Country
{
    public abstract class BaseCountryDto
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nazwa wymagana")]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
