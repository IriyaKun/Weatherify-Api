namespace Weatherify.DAL.Models
{
    public class Forecast : BaseEntity
    {
        public int CityId { get; set; }

        public int TemperatureInKelvin { get; set; }

        public virtual City City { get; set; }
    }
}