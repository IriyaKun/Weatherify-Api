using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Weatherify.DAL.Interfaces;

namespace Weatherify.DAL.Models
{
    public class BaseEntity : IEntity
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}