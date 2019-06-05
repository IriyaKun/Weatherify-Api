using System.Collections;
using System.Collections.Generic;

namespace Weatherify.DAL.Models
{
    public class User : BaseEntity
    {
        public virtual IEnumerable<City> Cities { get; set; }
    }
}