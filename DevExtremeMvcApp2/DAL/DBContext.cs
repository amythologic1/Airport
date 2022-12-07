using DevExtremeMvcApp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DevExtremeMvcApp2.DAL
{
    public class AirportContext : DbContext
    {
        public AirportContext() : base("DBConnection")
        {

        }

        public System.Data.Entity.DbSet<DevExtremeMvcApp2.Models.Airport> Airports { get; set; }
    }
    public class CountryContext : DbContext
    {
        public CountryContext() : base("DBConnection")
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}