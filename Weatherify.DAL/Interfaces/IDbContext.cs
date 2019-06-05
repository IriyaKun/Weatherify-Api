using System;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Weatherify.DAL.Models;

namespace Weatherify.DAL.Interfaces
{
    public interface IDbContext
    {
        DbSet<Forecast> Forecasts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<City> Cities { get; set; }

        void OnModelCreating(ModelBuilder builder);
    }
}