using System.Collections;
using System.Collections.Generic;

namespace Weatherify.DAL.Models
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        public virtual IEnumerable<Forecast> Forecasts { get; set; }
    }
}